using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    public class NewsCategory
    {
        [Key]
        public int ncId { get; set; }
        public string ncName { get; set; }
        public string ncDescription { get; set; }

        public DateTime? createAt { get; set; }

        public DateTime? updateAt { get; set; }

        public ICollection<News> News { get; set; }
        public void DeepCopy(NewsCategory newsCategory)
        {
            this.ncId = newsCategory.ncId;
            this.ncName = newsCategory.ncName;
            this.ncDescription = newsCategory.ncDescription;
            this.createAt = newsCategory.createAt;
            this.updateAt = newsCategory.updateAt;
        }
    }
}
