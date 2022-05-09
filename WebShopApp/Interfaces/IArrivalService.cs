using WebShopApp.Models;

namespace WebShopApp.Interfaces
{
    public interface IArrivalService
    {
        Task<IEnumerable<ArrivalModel>> GetAsync(CancellationToken cancellationToken);
    }
}
