using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions //service koleksiyonunu da genişletebileyim.
    {
        //Extensions yazdığımız class static olmalı.
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollection,ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
            //ServiceTool.Create(service) işlemini bütün modüller için yapabilmek için bu classı oluşturduk. 
            //bütün injecktionları bir araya toplayabileceğimiz yapı
        }
    }
}
