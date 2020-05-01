using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class Teacher
    {
        [Key]
        public int tId { get; set; }
        public string tDisplayName { get; set; }
        public string tAvatar { get; set; }

        public DateTime? createAt { get; set; } = DateTime.Now;

        public DateTime? updateAt { get; set; } = DateTime.Now;

        public ICollection<Course> Courses { get; set; }

        public void DeepCopy(Teacher teacher)
        {
            this.tId = teacher.tId;
            this.tDisplayName = teacher.tDisplayName;
            this.tAvatar = teacher.tAvatar;
            this.createAt = teacher.createAt;
            this.updateAt = teacher.updateAt;
        }
    }
}
