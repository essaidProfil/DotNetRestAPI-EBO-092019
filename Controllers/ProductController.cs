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
        /// Product Collection
        /// </summary>
        private const string CollectionId = "Products";
      
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
                var result = await CosmosDbStorage<Product>.GetItemsAsync(p => p.InStock);
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
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("GetProduct/{id}")]
        public async Task<HttpResponseMessage> GetProduct(string id)
        {
            try
            {
                var result = await CosmosDbStorage<Product>.GetItemsAsync(d => d.Id == id);
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
