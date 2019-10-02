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
        /// PId
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public string PId { get; set; }

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
        [JsonProperty(PropertyName = "promotionid")]
        public string PromotionId { get; set; }
    }
}