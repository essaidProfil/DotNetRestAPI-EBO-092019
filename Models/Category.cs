using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalogue.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Category
    {
        /// <summary>
    /// 
    /// </summary>
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Product Description")]
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}