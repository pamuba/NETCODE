using System.Text.RegularExpressions;

namespace middlewareDemo
{
    public class CustomConstraints : IRouteConstraint
    {
        bool IRouteConstraint.Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            //chk if values exist
            if (!values.ContainsKey(routeKey)) {
                return false;
            }

            Regex regex = new Regex($"^(apr|may)$");
            string? monthValue = Convert.ToString(values[routeKey]);

            if (regex.IsMatch(monthValue)) {
                return true;
            }
            return false;
        }
    }
}
