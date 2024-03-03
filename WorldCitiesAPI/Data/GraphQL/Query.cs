using Microsoft.EntityFrameworkCore;
using WorldCitiesAPI.Data.Models;
namespace WorldCitiesAPI.Data.GraphQL
{
    public class Query
    {
        /// <summary>
        /// Gets all Cities.
        /// </summary>
        [Serial]
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<City> GetCities(
            [Service] ApplicationDbContext context)
            => context.Cities;

        /// <summary>
        /// Gets all Countries.
        /// </summary>
        [Serial]
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Country> GetCountries(
            [Service] ApplicationDbContext context)
            => context.Countries;
    }
}
