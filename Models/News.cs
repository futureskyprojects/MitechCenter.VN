﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MitechCenter.vn.Utils;

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

        public DateTime? createAt { get; set; } = DateTime.Now;

        public DateTime? updateAt { get; set; } = DateTime.Now;

        [ForeignKey("ncId")]
        public virtual NewsCategory NewsCategory { get; set; }

        [ForeignKey("uId")]
        public virtual User User { get; set; }

        public void DeepCopy(News news)
        {
            this.nId = news.nId;
            this.ncId = news.ncId;
            this.uId = news.uId;
            this.nTitle = news.nTitle;
            this.nDescription = news.nDescription;
            this.nContent = news.nContent;
            this.nTags = news.nTags;
            this.nFeatureImage = news.nFeatureImage;
            this.createAt = news.createAt;
            this.updateAt = news.updateAt;
        }

        public NewsCategory getCategory(IEnumerable<NewsCategory> ns)
        {
            foreach (var newsCategory in ns)
            {
                if (this.ncId == newsCategory.ncId)
                    return newsCategory;
            }
            return null;
        }

        public string getPath()
        {
            return $"{nTitle.NonUnicode().Replace(" ", "-")}-{nId.ToString()}";
        }

        public string getDate()
        {
            if (createAt != null)
            {
                return ((DateTime)createAt).ToString("dd");
            }
            else
            {
                return "--";
            }
        }

        public string getMonth()
        {
            if (createAt != null)
            {
                return ((DateTime)createAt).ToString("MM");
            }
            else
            {
                return "--";
            }
        }
    }
}
