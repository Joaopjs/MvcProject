using Microsoft.AspNetCore.Mvc;
using MvcProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.ViewComponents
{
    public class FirstViewComponent:ViewComponent
    {
        public IMyClassService myClassService;

        public FirstViewComponent(IMyClassService myClass)
        {
            this.myClassService = myClass;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var myguid = await GetGuid();
            return View("Default", myguid);
        }

        private async Task<IMyClassService> GetGuid()
        {
            return await Task.FromResult(myClassService);
        }
    }
}
