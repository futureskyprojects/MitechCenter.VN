using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class Feedback
    {
        [Key]
        public int fId { get; set; }
        public int fFullname { get; set; }
        public string fAddress { get; set; }
        public string fPhone { get; set; }
        public string fEmail { get; set; }
        public string fContent { get; set; }
        public int? fReplyByUserId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime createAt { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime updateAt { get; set; } = DateTime.Now;

        [ForeignKey("fReplyByUserId")]
        public virtual User User { get; set; }
    }
}
