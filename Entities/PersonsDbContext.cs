﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Entities
{
    public class PersonsDbContext : DbContext
    {
        public PersonsDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        //public DbSet<Country> Countries1 { get; set; }

        public DbSet<Person> Persons { get; set; }
        //public DbSet<Person> Persons1 { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Person>().ToTable("Persons");

            ////Seed Data
            //modelBuilder.Entity<Country>().HasData(new Country()
            //{
            //    CountryID = Guid.NewGuid(),CountryName = "Japan"
            //});

            //Seed to Countries
            string countriesJson = System.IO.File.ReadAllText("countries.json");
            List<Country>? countries = System.Text.Json.JsonSerializer.Deserialize<List<Country>>(countriesJson);

            foreach (Country country in countries)
                modelBuilder.Entity<Country>().HasData(country);


            //Seed to Persons
            string personsJson = System.IO.File.ReadAllText("persons.json");
            List<Person>? persons = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(personsJson);

            foreach (Person person in persons)
                modelBuilder.Entity<Person>().HasData(person);

            //Fluent API
            //modelBuilder.Entity<Person>().Property(temp => temp.TIN)
            //    .HasColumnName("TaxIdentificationNumber")
            //    .HasColumnType("varchar(10)")
            //    .HasDefaultValue("ABCD9876");
                

        }

        public List<Person> sp_GetAllPersons() {
            return Persons.FromSqlRaw("EXECUTE [dbo].[GetAllPersons]").ToList();
        }

        public int sp_InsertPerson(Person person) {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@PersonID", person.PersonID),
                new SqlParameter("@PersonName", person.PersonName),
                new SqlParameter("@Email", person.Email),
                new SqlParameter("@DateOfBirth", person.DateOfBirth),
                new SqlParameter("@Gender", person.Gender),
                new SqlParameter("@CountryID", person.CountryID),
                new SqlParameter("@Address", person.Address),
                new SqlParameter("@ReceiveNewsLetters", person.ReceiveNewsLetters)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[InsertPerson] @PersonID," +
                "@PersonName, @Email, @DateOfBirth, @Gender, @CountryID," +
                "@Address, @ReceiveNewsLetters", parameters);
        }
    }
}
