using MvcProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Services
{
    public class MyClassService : IMyClassService
    {
        public Guid MyGuid { get; set; }

        public MyClassService()
        {
            MyGuid = Guid.NewGuid();
        }

    }
}
