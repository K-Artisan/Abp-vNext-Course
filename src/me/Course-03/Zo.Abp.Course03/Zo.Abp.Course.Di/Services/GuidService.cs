using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace Zo.Abp.Course.Di
{
    public class GuidService : ITransientDependency //, ISingletonDependency, IScopedDependency
    {
        private readonly Guid guid;
        public GuidService()
        {
            guid = Guid.NewGuid();
        }

        public string GetId()
        {
            return guid.ToString("N");
        }
    }
}
