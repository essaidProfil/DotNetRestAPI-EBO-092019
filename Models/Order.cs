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
        /// Unit price
        /// </summary>
        [JsonProperty(PropertyName = "unit_price")]
        public float UnitPrice { get; set; }
        /// <summary>
        /// Order Quantity
        /// </summary>
        [JsonProperty(PropertyName = "qty")]
        public int Quantity { get; set; }

        /// <summary>
        /// Order date
        /// </summary>
        [JsonProperty(PropertyName = "orderdate")]
        public string DateOrder { get; set; }

        /// <summary>
        /// Start promo from Promotions
        /// </summary>
        public string StartPromo { get; set; }

        /// <summary>
        /// End promo from Promotions
        /// </summary>
        public string EndPromo { get; set; }

        /// <summary>
        /// Order Status : Pending, Completed, Canceled...etc
        /// </summary>
        [JsonProperty(PropertyName = "orderstatus")]
        public string Status { get; set; }

        /// <summary>
        /// If is Promo from Products
        /// </summary>
        public bool IsPromo { get; set; }

        /// <summary>
        /// Total price
        /// </summary>
        /// <returns></returns>
        /// 
        //public float TotalPrice()
        //{
        //return UnitPrice * Quantity;
        //}

        /// <summary>
        /// Total price
        /// </summary>
        [JsonProperty(PropertyName = "ttlprice")]
        public float TotalPrice { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Promotion> Promotion { get; set; }

        /// <summary>
        /// Products
        /// </summary>
        public virtual ICollection<Product> Product { get; set; }

    }
}