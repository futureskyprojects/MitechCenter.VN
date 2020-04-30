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
        public StaticElement() { }
        public StaticElement(string eKey)
        {
            this.eId = -1;
            this.eKey = eKey;
            this.eData = "";
            this.eDescription = "";
            this.createAt = DateTime.Now;
            this.updateAt = DateTime.Now;
        }
        public StaticElement(int eId, string eKey, string eData, string eDescription, DateTime createAt, DateTime updateAt)
        {
            this.eId = eId;
            this.eKey = eKey;
            this.eData = eData;
            this.eDescription = eDescription;
            this.createAt = createAt;
            this.updateAt = updateAt;
        }
        [Key]
        public int eId { get; set; }

        public string eKey { get; set; }

        public string eData { get; set; }

        public string eDescription { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime createAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue("GETDATE()")]
        public DateTime updateAt { get; set; }
        public void DeepCopy(StaticElement staticElement)
        {
            this.eId = staticElement.eId;
            this.eKey = staticElement.eKey;
            this.eData = staticElement.eData;
            this.eDescription = staticElement.eDescription;
            this.createAt = staticElement.createAt;
            this.updateAt = staticElement.updateAt;
        }
    }
}
