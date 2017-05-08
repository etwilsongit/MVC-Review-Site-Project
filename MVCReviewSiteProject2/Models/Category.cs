using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject2.Models //we're using this class as a template
{
    public class Category
    {
        [Key] //data annotation, works on the field below them
        public int ID { get; set; } //IDs should ALWAYS be an int
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        
        //The bane of my existence, the straw that broke the programs back. The Comment Section. 
        public string Comment { get; set; }


        public virtual ICollection<Review> Reviews { get; set; }

    }
}