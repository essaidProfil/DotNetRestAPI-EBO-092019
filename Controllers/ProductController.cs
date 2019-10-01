using System;
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
    /// Produits
    /// </summary>
    public class ProductController : ApiController
    {
        /// <summary>
        /// Get All Available Products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetAllProducts")]
        public async Task<HttpResponseMessage> GetAllProducts()
        {
            try
            {
                var result = await CosmosDbStorage<Product>.GetItemsAsync(d => d.InStock == true);
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
        /// Get Product details by id
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("GetProduct/{pid}")]
        public async Task<HttpResponseMessage> GetProduct(string pid)
        {
            try
            {
                var result = await CosmosDbStorage<Product>.GetItemsAsync(d => d.PId == pid);
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
