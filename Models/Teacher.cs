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
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime createAt { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime updateAt { get; set; } = DateTime.Now;

        public ICollection<Course> Courses { get; set; }
    }
}
