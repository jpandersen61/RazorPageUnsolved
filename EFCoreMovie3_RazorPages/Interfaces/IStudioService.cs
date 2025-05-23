﻿using EFCoreMovie2_RazorPages.Models;

namespace EFCoreMovie3_RazorPages.Interfaces
{
    public interface IStudioService
    {        
        public IEnumerable<Studio> GetStudios();
        IEnumerable<Studio> GetStudios(string name);
    }
}
