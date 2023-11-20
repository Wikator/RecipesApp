using Microsoft.EntityFrameworkCore;
using RecipesApp.Entities;
using RecipesApp.Shared.Helpers;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace RecipesApp.Extensions
{
    public static class QueryableExtensions
    {
        public static async Task<PagedList<TDto>> CreatePagedList<TDto>(this IQueryable<TDto> query, int pageNumber, int pageSize)
        {
            int count = await query.CountAsync();
            IEnumerable<TDto> items = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PagedList<TDto>(items, pageNumber, pageSize, count);
        }

        public static IQueryable<T> ApplySort<T>(this IQueryable<T> entities, string? orderByQueryString)
        {
            if (!entities.Any())
                return entities;

            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return entities;

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Recipe).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;
                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));
                if (objectProperty == null)
                    continue;
                var sortingOrder = param.EndsWith(" desc") ? "descending" : "ascending";
                orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {sortingOrder}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
            if (string.IsNullOrWhiteSpace(orderQuery))
                return entities;

            return entities.OrderBy(orderQuery);
        }
    }
}
