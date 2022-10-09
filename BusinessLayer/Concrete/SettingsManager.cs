using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class SettingsManager : ISettingService
    {
        ISettingsDal settingsDal;

        public SettingsManager(ISettingsDal settingsDal)
        {
            this.settingsDal = settingsDal;
        }

        public Settings GetByID(int id)
        {
            return settingsDal.GetByID(id);
        }

        public void TAdd(Settings t)
        {
            settingsDal.Insert(t);
        }

        public void TDelete(Settings t)
        {
            settingsDal.Delete(t);
        }

        public List<Settings> TGetList()
        {
            return settingsDal.GetList();
        }

        public void TUpdate(Settings t)
        {
            settingsDal.Update(t);
        }
    }
}
