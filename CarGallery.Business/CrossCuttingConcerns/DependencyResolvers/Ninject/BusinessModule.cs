using CarGallery.Business.Abstract;
using CarGallery.Business.Concrete;
using CarGallery.DataAccess.Abstract;
using CarGallery.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGallery.Business.CrossCuttingConcerns.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICarService>().To<CarManager>().InSingletonScope();
            Bind<ICarDal>().To<EFCarDal>().InSingletonScope();
        }
    }
}
