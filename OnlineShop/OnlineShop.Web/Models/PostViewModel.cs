﻿using System;
using System.Collections.Generic;

namespace OnlineShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public int CategoryID { set; get; }

        public string Image { set; get; }

        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { get; set; }

        public virtual PostCategoryViewModel PostCategory { set; get; }

        public virtual IEnumerable<PostTagViewModel> PostTags { get; set; }
    }
}