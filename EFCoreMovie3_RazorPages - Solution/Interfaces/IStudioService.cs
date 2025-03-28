using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie3_RazorPages.Interfaces
{
    public interface IStudioService
    {        
        public IEnumerable<Studio> GetStudios();
        public IEnumerable<Studio> GetStudios(string name);
        public void AddStudio(Studio studio);
        public Studio ? GetStudioById(int id);
        public void DeleteStudio(Studio studio);
    }
}
