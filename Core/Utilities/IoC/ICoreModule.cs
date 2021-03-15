using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public interface ICoreModule
    {
        //Tüm propjelerimizde kullanıcağımız kodları içerir
       //tüm servisleri yüklüyr.
        void Load(IServiceCollection serviceCollection);
    }
}
