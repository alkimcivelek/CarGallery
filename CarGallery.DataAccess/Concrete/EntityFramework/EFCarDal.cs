using CarGallery.DataAccess.Abstract;
using CarGallery.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGallery.DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFRepositoryBase<Car, CarGalleryContext>, ICarDal
    {
    }
}
