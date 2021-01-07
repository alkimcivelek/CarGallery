using CarGallery.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGallery.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
    }
}
