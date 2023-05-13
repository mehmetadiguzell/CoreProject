using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public List<Skill> GetByFilterList()
        {
            throw new System.NotImplementedException();
        }

        public void TAdd(Skill entity)
        {
            _skillDal.Insert(entity);
        }

        public void TDelete(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public Skill TGetById(int id = 0)
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
