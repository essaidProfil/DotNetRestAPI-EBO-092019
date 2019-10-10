using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Catalogue.Models
{
    /// <summary>
    /// Order Model
    /// </summary>
    public class Order
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Product ordered id
        /// </summary>
        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// Order Quantity
        /// </summary>
        [JsonProperty(PropertyName = "qty")]
        public string Quantity { get; set; }

        /// <summary>
        /// Order date
        /// </summary>
        [JsonProperty(PropertyName = "orderdate")]
        public string DateOrder { get; set; }

        /// <summary>
        /// Order Status : Pending, Completed, Canceled...etc
        /// </summary>
        [JsonProperty(PropertyName = "orderstatus")]
        public string Status { get; set; }

        /// <summary>
        /// Total price
        /// </summary>
        [JsonProperty(PropertyName = "ttlprice")]
        public double TotalPrice { get; set; }
    }
}