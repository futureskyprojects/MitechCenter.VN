using System.Collections.Generic;
using System.Linq;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Models.DataManager
{
    public class NewsCategoryManager : IDataRepository<NewsCategory>
    {
        readonly MitechCenterContext _context;
        public NewsCategoryManager(MitechCenterContext context)
        {
            _context = context;
        }

        public void Add(NewsCategory entity)
        {
            _context.NewsCategories.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(NewsCategory entity)
        {
            _context.NewsCategories.Remove(entity);
            _context.SaveChanges();
        }

        public NewsCategory Get(long id)
        {
            return _context.NewsCategories.FirstOrDefault(e => e.ncId == id);
        }

        public NewsCategory Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<NewsCategory> GetAll()
        {
            return _context.NewsCategories.ToList();
        }

        public void Update(NewsCategory dbEntity, NewsCategory entity)
        {
            dbEntity.DeepCopy(entity);
            _context.SaveChanges();
        }
    }
}