using Microsoft.EntityFrameworkCore;
using Presentation.Data;

namespace Presentation.Services;

public class TosServices(DataContext context)
    {
    private readonly DataContext _context = context;

    public async Task<IEnumerable<TosEntity>> GetAllAsync()
        {
        var tos = await _context.TosServices.ToListAsync();
        return tos;
        }

    }

