using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalogue.Models
{
    /// <summary>
    /// First promotion type
    /// </summary>
    public class Promotion
    {
        /// <summary>
        /// Promotion Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        /// <summary>
        /// Promotion Name
        /// </summary>
        [JsonProperty(PropertyName = "promotion_name")]
        public string PromotionName { get; set; }

        /// <summary>
        /// Promotion start date 
        /// </summary>
        [JsonProperty(PropertyName = "start_date")]
        public string StartPromo { get; set; }

        /// <summary>
        /// Promotion End date
        /// </summary>
        [JsonProperty(PropertyName = "end_date")]
        public string EndPromo { get; set; }



    }
}