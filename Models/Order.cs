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
        public int Id { get; set; }
        
        /// <summary>
        /// Champ du Prénom 
        /// </summary>
        [JsonProperty(PropertyName = "firstname")]
        [Required(ErrorMessage = "Le Prénom est obligatoire !")]
        [DisplayName("Prénom")]
        [StringLength(160)]
        public string Fname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "lastname")]
        [Required(ErrorMessage = "Le Nom est obligatoire !")]
        [DisplayName("Nom")]
        [StringLength(160)]
        public string Lname { get; set; }

        /// <summary>
        /// Champ d'Adresse
        /// </summary>
        [JsonProperty(PropertyName = "adresse")]
        [Required(ErrorMessage = "l'adresse est obligatoire !")]
        [DisplayName("Adresse")]
        [StringLength(70)]
        public string Address { get; set; }

        /// <summary>
        /// Town
        /// </summary>
        [JsonProperty(PropertyName = "ville")]
        [Required(ErrorMessage = "Le nom de la ville est obligatoire !")]
        [DisplayName("Ville")]
        [StringLength(40)]
        public string Town { get; set; }

        /// <summary>
        /// Champ du pays
        /// </summary>
        [JsonProperty(PropertyName = "pays")]
        [Required(ErrorMessage = "Le nom de votre pays est obligatoire !")]
        [DisplayName("Votre pays")]
        [StringLength(40)]
        public string Country { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty(PropertyName = "courriel")]
        [Required(ErrorMessage = "Vous devez renseigner votre adresse couriel")]
        [DisplayName("Votre courriel")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "L'adresse courriel est invalid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Numéro de téléphone
        /// </summary>
        [JsonProperty(PropertyName = "tel")]
        [StringLength(25)]
        public string Phone { get; set; }

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