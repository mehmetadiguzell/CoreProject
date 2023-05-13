using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public List<Feature> GetByFilterList()
        {
            throw new System.NotImplementedException();
        }

        public void TAdd(Feature entity)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Feature entity)
        {
            throw new System.NotImplementedException();
        }

        public Feature TGetById(int id = 0)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
