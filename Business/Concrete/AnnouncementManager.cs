using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public List<Announcement> GetByFilterList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetById(int id = 0)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.GetList();
        }

        public void TUpdate(Announcement entity)
        {
            throw new NotImplementedException();
        }
    }
}
