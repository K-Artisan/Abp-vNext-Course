using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace Zo.Abp.Course.Di.Services
{
    //[ExposeServices(typeof(IDemoExposeService))]
    [ExposeServices(typeof(IDemoExposeService), IncludeSelf = true)]
    [Dependency(ServiceLifetime.Transient)]
    public class DemoExposeService : IDemoExposeService
    {
        private readonly Guid guid;
        public DemoExposeService()
        {
            guid = Guid.NewGuid();
        }

        public string GetId()
        {
            return guid.ToString("N");
        }

    }
}
