using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalRApi.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void TAdd(About entity)
        {
            _aboutdal.Add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutdal.Delete(entity);
        }

        public About TGetByID(int id)
        {
           return _aboutdal.GetByID(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutdal.GetlistAll();
        }

        public void TUpdate(About entity)
        {
            _aboutdal.Update(entity);
        }
    }
}
