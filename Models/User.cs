using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class User
    {
        [Key]
        public int uId { get; set; }
        public string username { get; set; }
        public string encryptPassword { get; set; }
        public string displayName { get; set; }
        public string avatar { get; set; }
        public int role { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime? createAt { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime? updateAt { get; set; } = DateTime.Now;

        public ICollection<User> AboutUs { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<News> News { get; set; }

        public void DeepCopy(User user)
        {
            this.uId = user.uId;
            this.username = user.username;
            this.encryptPassword = user.encryptPassword;
            this.displayName = user.displayName;
            this.avatar = user.avatar;
            this.role = user.role;
            this.createAt = user.createAt;
            this.updateAt = user.updateAt;
        }
    }
}
