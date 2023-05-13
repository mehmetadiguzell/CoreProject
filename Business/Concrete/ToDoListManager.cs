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
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public List<ToDoList> GetByFilterList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(ToDoList entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ToDoList entity)
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetById(int id = 0)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public void TUpdate(ToDoList entity)
        {
            throw new NotImplementedException();
        }
    }
}
