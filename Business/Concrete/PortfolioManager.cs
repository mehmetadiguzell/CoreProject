using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        private readonly IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public List<Portfolio> GetByFilterList()
        {
            throw new System.NotImplementedException();
        }

        public void TAdd(Portfolio entity)
        {
            _portfolioDal.Insert(entity);
        }

        public void TDelete(Portfolio entity)
        {
            _portfolioDal.Delete(entity);
        }

        public Portfolio TGetById(int id = 0)
        {
            return _portfolioDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio entity)
        {
            _portfolioDal.Update(entity);
        }
    }
}
