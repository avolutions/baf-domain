using Microsoft.EntityFrameworkCore;
using Avolutions.Baf.Domain.Addresses.Abstractions;

namespace Avolutions.Baf.Domain.Addresses.Extensions;

public static class AddressQueryExtensions
{
    public static IQueryable<T> IncludeAddress<T>(this IQueryable<T> query) 
        where T : class, IHasAddress
    {
        return query.Include(x => x.Address);
    }
}