using EFCoreMovie2_RazorPages.Models;
using EFCoreMovie3_RazorPages.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovie3_RazorPages.EFServices
{
    public class EFStudioService : IStudioService
    {
        MovieDBContext dbContext;
        public EFStudioService(MovieDBContext context)
        {
            dbContext = context;
        }
        public IEnumerable<Studio> GetStudios()
        {
            return dbContext.Studios;
        }

        public IEnumerable<Studio> GetStudios(string name)
        {
            return dbContext.Studios.Where(s => s.Name.StartsWith(name)).AsNoTracking().ToList();
        }
    }
}
