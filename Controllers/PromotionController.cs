using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Catalogue.Models;
using Newtonsoft.Json;

namespace Catalogue.Controllers
{
/// <summary>
/// Promotion controller
/// </summary>
    public class PromotionController : ApiController
    {
        /// <summary>
        /// Get all active promotion
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetPromotions")]
        public async Task<HttpResponseMessage> GetPromotions()
        {
            try
            {
                var result = await CosmosDbStorage<Promotion>.GetItemsAsync(p => p.PromoEnabled == true);
                return new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.Found,
                    Content = new StringContent(JsonConvert.SerializeObject(result), Encoding.UTF8, "application/json")
                };
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
        }

        /// <summary>
        /// Ajouter des promotions
        /// </summary>
        /// <param name="promo"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddPromotion")]
        public async Task<HttpResponseMessage> AddPromotion([System.Web.Mvc.Bind(Include = "PromotionId,PromotionName,StartPromo,EndPromo,CodePromo,PromoEnabled")] Promotion promo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await CosmosDbStorage<Promotion>.CreateItemAsync(promo);

                    return new HttpResponseMessage(HttpStatusCode.Created);
                }
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
        }

        /// <summary>
        /// Update Promotions
        /// </summary>
        /// <param name="promo"></param>
        /// <returns></returns>
        [HttpPut]
        [ActionName("UpdatePromotion")]
        public async Task<HttpResponseMessage> UpdatePromotion([System.Web.Mvc.Bind(Include = "PromotionId,PromotionName,StartPromo,EndPromo,CodePromo,PromoEnabled")] Promotion promo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await CosmosDbStorage<Promotion>.UpdateItemAsync(promo.PromotionId, promo);

                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }

        }

    }
}
