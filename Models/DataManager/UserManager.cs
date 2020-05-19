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
            entity.username = entity.username.ToLower();
            entity.encryptPassword = Password.Encrypt(entity.encryptPassword);
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(User entity)
        {
            if (entity.username == "admin")
            {
                throw new System.Exception("Không thể xóa quản trị viên mặc định");
            }
            else
            {
                _context.Users.Remove(entity);
                _context.SaveChanges();
            }
        }

        public User Get(long id)
        {
            return _context.Users.FirstOrDefault(e => e.uId == id);
        }

        public User Find(string username, string password)
        {
            var found = _context.Users.First(u => u.username == username.ToLower());
            if (found.username == "admin" && found.encryptPassword == "admin")
            {
                return found;
            }
            else if (found.encryptPassword == Password.Encrypt(password))
                return found;
            else
                return null;
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