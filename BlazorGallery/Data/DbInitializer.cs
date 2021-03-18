using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGallery.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StorageService context)
        {
            context.Database.EnsureCreated();
        }
    }
}
