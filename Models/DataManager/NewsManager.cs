using System.Collections.Generic;
using System.Linq;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Models.DataManager
{
    public class NewsManager : IDataRepository<News>
    {
        readonly MitechCenterContext _context;
        public NewsManager(MitechCenterContext context)
        {
            _context = context;
        }

        public void Add(News entity)
        {
            _context.TheNews.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(News entity)
        {
            _context.TheNews.Remove(entity);
            _context.SaveChanges();
        }

        public News Get(long id)
        {
            return _context.TheNews.FirstOrDefault(e => e.nId == id);
        }

        public News Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<News> GetAll()
        {
            return _context.TheNews.ToList();
        }

        public void Update(News dbEntity, News entity)
        {
            dbEntity.DeepCopy(entity);
            _context.SaveChanges();
        }
    }
}