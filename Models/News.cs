using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class News
    {
        [Key]
        public int nId { get; set; }
        public int ncId { get; set; }
        public int uId { get; set; }
        public string nTitle { get; set; }
        public string nDescription { get; set; }
        public string nContent { get; set; }
        public string nTags { get; set; }
        public string nFeatureImage { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime createAt { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime updateAt { get; set; } = DateTime.Now;
        
        [ForeignKey("ncId")]
        public virtual NewsCategory NewsCategory { get; set; }

        [ForeignKey("uId")]
        public virtual User User { get; set; }
    }
}
