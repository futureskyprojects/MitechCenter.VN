using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class AboutUs
    {
        [Key]
        public int auId { get; set; }
        public string auTitle { get; set; }
        public string auContent { get; set; }
        public int uId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue(false)]
        public bool isServices { get; set; }

        public DateTime? createAt { get; set; } = DateTime.Now;

        public DateTime? updateAt { get; set; } = DateTime.Now;

        [ForeignKey("uId")]
        public virtual User User { get; set; }

        public void DeepCopy(AboutUs about)
        {
            this.auId = about.auId;
            this.auTitle = about.auTitle;
            this.auContent = about.auContent;
            this.uId = about.uId;
            this.createAt = about.createAt;
            this.updateAt = DateTime.Now;
        }
    }
}
