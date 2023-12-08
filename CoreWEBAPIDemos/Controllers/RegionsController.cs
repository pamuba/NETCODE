using AutoMapper;
using CoreWEBAPIDemos.CustomActionFilters;
using CoreWEBAPIDemos.Data;
using CoreWEBAPIDemos.Models.Domain;
using CoreWEBAPIDemos.Models.DTO;
using CoreWEBAPIDemos.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreWEBAPIDemos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class RegionsController : ControllerBase
    {
        private readonly WalkDbContext dbContext;
        public IRegionRepository regionRepository { get; }
        public IMapper mapper { get; }

        public RegionsController(WalkDbContext dbContext, IRegionRepository regionRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetAll() {
            var regionsDomain = await regionRepository.GetAllAsync();
            return Ok(mapper.Map<List<RegionDto>>(regionsDomain));
        }
        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var regionDomain = await regionRepository.GetByIdAsync(id);
            if (regionDomain == null)
            {
                return NotFound();
            }
            
            return Ok(mapper.Map<RegionDto>(regionDomain));
        }
        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            //if (ModelState.IsValid)
            //{
                var regionDomainModel = mapper.Map<Region>(addRegionRequestDto);

                regionDomainModel = await regionRepository.CreateAsync(regionDomainModel);

                var regionDto = mapper.Map<RegionDto>(regionDomainModel);

                return CreatedAtAction(nameof(GetById), new { id = regionDto.Id }, regionDto);
            //}
            //else {
                //return BadRequest(ModelState);
            //}
        }
        [HttpPut]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, 
            [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            if (ModelState.IsValid)
            {
                var regionDomainModel = mapper.Map<Region>(updateRegionRequestDto);

                regionDomainModel = await regionRepository.UpdateAsync(id, regionDomainModel);

                if (regionDomainModel == null)
                {
                    return NotFound();
                }

                return Ok(mapper.Map<RegionDto>(regionDomainModel));

            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Reader, Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id) {
            var regioDomainModel = await regionRepository.DeleteAsync(id);

            if(regioDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RegionDto>(regioDomainModel));
        }
    }
}
