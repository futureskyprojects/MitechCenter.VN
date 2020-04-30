using System.Collections.Generic;
using System.Linq;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Models.DataManager
{
    public class UserManager : IDataRepository<User>
    {
        readonly MitechCenterContext _context;
        public UserManager(MitechCenterContext context)
        {
            _context = context;
        }

        public void Add(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public User Get(long id)
        {
            return _context.Users.FirstOrDefault(e => e.uId == id);
        }

        public User Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Update(User dbEntity, User entity)
        {
            dbEntity.DeepCopy(entity);
            _context.SaveChanges();
        }
    }
}