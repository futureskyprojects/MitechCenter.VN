using System.Collections.Generic;
using System.Linq;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Models.DataManager
{
    public class CourseManager : IDataRepository<Course>
    {
        readonly MitechCenterContext _context;

        public CourseManager()
        {
        }

        public CourseManager(MitechCenterContext context)
        {
            _context = context;
        }

        public void Add(Course entity)
        {
            _context.Courses.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Course entity)
        {
            _context.Courses.Remove(entity);
            _context.SaveChanges();
        }

        public Course Get(long id)
        {
            return _context.Courses.FirstOrDefault(e => e.cId == id);
        }

        public Course Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public void Update(Course dbEntity, Course entity)
        {
            dbEntity.DeepCopy(entity);
            _context.SaveChanges();
        }
    }
}