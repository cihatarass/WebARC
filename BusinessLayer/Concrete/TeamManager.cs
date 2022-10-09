using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public Team GetByID(int id)
        {
            return _teamDal.GetByID(id);
        }

        public void TAdd(Team t)
        {
            _teamDal.Insert(t);
        }

        public void TDelete(Team t)
        {
            _teamDal.Delete(t);
        }

        public List<Team> TGetList()
        {
            return _teamDal.GetList();
        }

        public void TUpdate(Team t)
        {
            _teamDal.Update(t);
        }
    }
}
