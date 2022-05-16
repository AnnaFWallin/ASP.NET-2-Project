using AutoMapper;
using WebShopApp.Interfaces;
using WebShopApp.Models;
using Microsoft.EntityFrameworkCore;
using WebShopApp.Interfaces;
using WebShopApp.Models.Entities;
using WebShopApp.Data;

namespace WebShopApp.Services;

public class CategoryService : ICategoryService
{
    private readonly ApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public CategoryService(ApplicationDbContext applicationDbContext, IMapper mapper)
    {
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    public async Task<CategoryModel> AddAsync(CategoryModel categoryModel, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<CategoryEntity>(categoryModel);
        await _applicationDbContext.Categories.AddAsync(category, cancellationToken);
        await _applicationDbContext.SaveChangesAsync(cancellationToken);
        return _mapper.Map<CategoryModel>(categoryModel);

    }

    public async Task<CategoryModel> UpdateAsync(CategoryModel categoryModel, CancellationToken cancellationToken)
    {
       
        var category = _mapper.Map<CategoryEntity>(categoryModel);
        if(category.Id == 0)
        {
            throw new Exception("Id cannot be 0");
        }

        _applicationDbContext.Categories.Update(category);
        var affectedRows = await _applicationDbContext.SaveChangesAsync(cancellationToken);
        if(affectedRows > 0)
        {
            return _mapper.Map<CategoryModel>(category);
        }
        throw new Exception("Could not update database");
    }

    public async Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
    {
        try
        {
            _applicationDbContext.Categories.Remove(new CategoryEntity() { Id = id });
            var affectedRows = await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return (affectedRows > 0);
        }
        catch
        {
            return false;
        }
        
    }

    public async Task<CategoryModel> GetAsync(int id, CancellationToken cancellationToken)
    {
        var category = await _applicationDbContext.Categories
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        
        if(category == null)
        {
            return null!;
        }

        return _mapper.Map<CategoryModel>(category);
    }

    public async Task<IEnumerable<CategoryModel>> GetAsync(CancellationToken cancellationToken)
    {
        return _mapper.Map<IEnumerable<CategoryModel>>(await _applicationDbContext.Categories
            .AsNoTracking()
            .ToArrayAsync(cancellationToken));
    }
}
