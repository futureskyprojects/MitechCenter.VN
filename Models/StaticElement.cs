using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class StaticElement
    {
        [Key]
        public int eId { get; set; }

        public string eKey { get; set; }

        public string eData { get; set; }

        public string eDescription { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime createAt { get; set; } = DateTime.Now;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime updateAt { get; set; } = DateTime.Now;
    }
}
