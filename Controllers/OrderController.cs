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
    /// Order Controller
    /// </summary>
    public class OrderController : ApiController
    {
        /// <summary>
        /// Place Order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("AddOrder")]
        public async Task<HttpResponseMessage> AddOrder([System.Web.Mvc.Bind(Include = "Id,Fname,Lname,Address,Town,Country,Email,Phone,ProductId,Quantity,DateOrder,Status,TotalPrice")] Order order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await CosmosDbStorage<Order>.CreateItemAsync(order);

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
        /// Enlever un produit du panier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [ActionName("DeleteOrder/{id}")]
        public async Task<HttpResponseMessage> DeleteOrder(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);

                await CosmosDbStorage<Order>.DeleteAsync(id);

                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
        }

        /// <summary>
        /// Get all orders
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        [System.Web.Http.ActionName("GetOrders")]
        public async Task<HttpResponseMessage> GetOrders()
        {
            try
            {
                var result = await CosmosDbStorage<Order>.GetItemsAsync(o => o.Id != null); ;
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
    }
}
