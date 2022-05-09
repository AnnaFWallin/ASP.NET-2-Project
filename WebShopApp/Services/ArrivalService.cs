using AutoMapper;
using WebShopApp.Interfaces;
using WebShopApp.Models;
using Microsoft.EntityFrameworkCore;
using WebShopApp.Data;

namespace WebShopApp.Services;

public class ArrivalService : IArrivalService
{
    private readonly ApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public ArrivalService(ApplicationDbContext applicationDbContext, IMapper mapper)
    {
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }


    public async Task<IEnumerable<ArrivalModel>> GetAsync(CancellationToken cancellationToken)
    {
        return _mapper.Map<IEnumerable<ArrivalModel>>(await _applicationDbContext.Products
            .Include(x => x.Category)
            .OrderByDescending(p => p.CreatedDate)
            .Take(9)
            .AsNoTracking()
            .ToArrayAsync(cancellationToken));
    }
}
