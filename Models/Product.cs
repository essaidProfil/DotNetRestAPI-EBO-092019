using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalogue.Models
{
    /// <summary>
    /// Product Model
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Product Category
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string ProductCategory { get; set; }

        /// <summary>
        /// Product Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Product Price
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public double ProductPrice { get; set; }

        /// <summary>
        /// Product Availability
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool InStock { get; set; }

        /// <summary>
        /// Product Promotion
        /// </summary>
        [JsonProperty(PropertyName = "ispromo")]
        public bool IsPromo { get; set; }

        /// <summary>
        /// Start promo date If is promo
        /// </summary>
        public string StartPromo { get; set; }

        /// <summary>
        /// End promo date
        /// </summary>
        public string EndPromo { get; set; }

        /// <summary>
        /// Promotion
        /// </summary>
        public virtual ICollection<Promotion> Promotion { get; set; }

    }
}