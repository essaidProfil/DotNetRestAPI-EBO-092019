using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalogue.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Promotion
    {
        /// <summary>
        /// Promotion Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string PromotionId { get; set; }
        /// <summary>
        /// Promotion Name
        /// </summary>
        [JsonProperty(PropertyName = "promotion_name")]
        public string PromotionName { get; set; }

        /// <summary>
        /// Promotion start date | First promotion type | Limited by date
        /// </summary>
        [JsonProperty(PropertyName = "start_date")]
        public string StartPromo { get; set; }

        /// <summary>
        /// Promotion End date
        /// </summary>
        [JsonProperty(PropertyName = "end_date")]
        public string EndPromo { get; set; }

        /// <summary>
        /// 2nd promo | By promo code
        /// </summary>
        [JsonProperty(PropertyName = "code_promo")]
        public string CodePromo { get; set; }

        /// <summary>
        /// Promo status
        /// </summary>
        [JsonProperty(PropertyName = "activepromo")]
        public bool PromoEnabled { get; set; }

    }
}