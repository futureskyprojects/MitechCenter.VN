using System;
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

        public IEnumerable<News> GetAll(long ncId)
        {
            return _context.TheNews.Where(x => x.ncId == ncId).ToList();
        }

        public News getPreviousPost(long currentPostId, long categoryId)
        {
            try
            {
                return _context.TheNews
                .Where(x => x.nId < currentPostId && x.ncId == categoryId)
                .OrderByDescending(x => x.nId)
                .First();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public News getNextPost(long currentPostId, long categoryId)
        {
            try
            {
                return _context.TheNews
                .Where(x => x.nId > currentPostId && x.ncId == categoryId)
                .OrderBy(x => x.nId)
                .First();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<News> GetSize(int size)
        {
            return _context.TheNews.Take(size).ToList();
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