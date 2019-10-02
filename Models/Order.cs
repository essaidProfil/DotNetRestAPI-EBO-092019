using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        /// Item id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Order id
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string IDOrder { get; set; }

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
        /// Custumer ID - Client
        /// </summary>
        [JsonProperty(PropertyName = "customer_id")]
        public string UserID { get; set; }

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
        public string TotalPrice { get; set; }
    }
}