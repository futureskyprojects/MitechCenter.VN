using System.Collections.Generic;
using System.Linq;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Models.DataManager
{
    public class TeacherManager : IDataRepository<Teacher>
    {
        readonly MitechCenterContext _context;
        public TeacherManager(MitechCenterContext context)
        {
            _context = context;
        }

        public void Add(Teacher entity)
        {
            _context.Teachers.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Teacher entity)
        {
            _context.Teachers.Remove(entity);
            _context.SaveChanges();
        }

        public Teacher Get(long id)
        {
            return _context.Teachers.FirstOrDefault(e => e.tId == id);
        }

        public Teacher Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public void Update(Teacher dbEntity, Teacher entity)
        {
            dbEntity.DeepCopy(entity);
            _context.SaveChanges();
        }
    }
}