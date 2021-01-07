using CarGallery.Business.Abstract;
using CarGallery.DataAccess.Abstract;
using CarGallery.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarGallery.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            _carDal.Add(entity);
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _carDal.Get(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carDal.GetAll();
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
