﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject2.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Rating { get; set; }
        public string Location { get; set; }
        public string Comment { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}