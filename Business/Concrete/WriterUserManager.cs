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
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public List<WriterUser> GetByFilterList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(WriterUser entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterUser entity)
        {
            throw new NotImplementedException();
        }

        public WriterUser TGetById(int id = 0)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetList()
        {
            return _writerUserDal.GetList();
        }

        public void TUpdate(WriterUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
