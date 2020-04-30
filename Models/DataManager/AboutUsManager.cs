using System.Collections.Generic;
using System.Linq;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Models.DataManager
{
    public class AboutUsManager : IDataRepository<AboutUs>
    {
        readonly MitechCenterContext _context;
        public AboutUsManager(MitechCenterContext context)
        {
            _context = context;
        }

        public void Add(AboutUs entity)
        {
            _context.Abouts.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(AboutUs entity)
        {
            _context.Abouts.Remove(entity);
            _context.SaveChanges();
        }

        public AboutUs Get(long id)
        {
            return _context.Abouts.FirstOrDefault(e => e.auId == id);
        }

        public AboutUs Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AboutUs> GetAll()
        {
            return _context.Abouts.ToList();
        }

        public void Update(AboutUs dbEntity, AboutUs entity)
        {
            dbEntity.DeepCopy(entity);
            _context.SaveChanges();
        }
    }
}