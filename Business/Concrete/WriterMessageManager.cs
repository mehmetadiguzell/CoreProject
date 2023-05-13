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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }
        public List<WriterMessage> GetByFilterList()
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageDal.GetByFilterList(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetByFilterList(x => x.Sender == p);
        }

        public void TAdd(WriterMessage entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterMessage entity)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id = 0)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
