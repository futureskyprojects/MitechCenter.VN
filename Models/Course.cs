using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class Course
    {
        [Key]
        public int cId { get; set; }
        public int tId { get; set; }
        public string cName { get; set; }
        public float cPrice { get; set; }
        public string cLearningTime { get; set; }
        public string cDescription { get; set; }
        public string cDetail { get; set; }
        public string cSchedule { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime createAt { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime updateAt { get; set; } = DateTime.Now;

        [ForeignKey("tId")]
        public virtual Teacher Teacher { get; set; }
    }
}
