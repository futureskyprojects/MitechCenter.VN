using System.Collections.Generic;
using System.Linq;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Models.DataManager
{
    public class FeedbackManager : IDataRepository<Feedback>
    {
        readonly MitechCenterContext _context;
        public FeedbackManager(MitechCenterContext context)
        {
            _context = context;
        }

        public void Add(Feedback entity)
        {
            _context.Feedbacks.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Feedback entity)
        {
            _context.Feedbacks.Remove(entity);
            _context.SaveChanges();
        }

        public Feedback Get(long id)
        {
            return _context.Feedbacks.FirstOrDefault(e => e.fId == id);
        }

        public Feedback Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Feedback> GetAll()
        {
            return _context.Feedbacks.ToList();
        }

        public void Update(Feedback dbEntity, Feedback entity)
        {
            dbEntity.DeepCopy(entity);
            _context.SaveChanges();
        }
    }
}