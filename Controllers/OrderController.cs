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
    /// 
    /// </summary>
    public class OrderController : ApiController
    {
        /// <summary>
        /// Get all orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetOrders")]
        public async Task<HttpResponseMessage> GetOrders()
        {
            try
            {
                var result = await CosmosDbStorage<Order>.GetItemsAsync(o => o.Username != null); ;
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
        /// Place Order
        /// </summary>
        /// <param name="Order"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddOrder")]
        public async Task<HttpResponseMessage> AddOrder([System.Web.Mvc.Bind(Include = "IDOrder,ProductId,Quantity,UserID,DateOrder,Status,TotalPrice")] Order Order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await CosmosDbStorage<Order>.CreateItemAsync(Order);

                    return new HttpResponseMessage(HttpStatusCode.Created);
                }
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
        }
    }
}
