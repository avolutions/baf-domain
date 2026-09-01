using Avolutions.Baf.Domain.Communications.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Communications.Extensions;

public static class CommuicationQueryExtensions
{
    public static IQueryable<T> IncludeCommunication<T>(this IQueryable<T> query) 
        where T : class, IHasCommunication
    {
        return query.Include(x => x.Communication);
    }
}