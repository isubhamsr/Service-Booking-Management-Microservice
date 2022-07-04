using Microsoft.AspNetCore.Mvc;
using Service_Booking_Management_Microservice.Model;
using System.Collections.Generic;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Service_Booking_Management_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceReqController : ControllerBase
    {
        private List<AppService> services = new List<AppService>();
        private IDictionary<string, dynamic> response = new Dictionary<string, dynamic>();
        public ServiceReqController()
        {
            services.Add(new AppService { Id = 1, ProductId = 1, UserId = 1, Description = "Service Done", Problem = "Not working", ReqDate = DateTime.Now, Status = "resolved" });
            services.Add(new AppService { Id = 2, ProductId = 2, UserId = 2, Description = "Service Done", Problem = "Not working", ReqDate = DateTime.Now, Status = "pending" });
        }

        // GET: api/<ServiceReqController>
        [HttpGet]
        public string Get()
        {
            try
            {
                if(services.Count > 0)
                {
                    response.Add("error", false);
                    response.Add("message", "Services are fetch");
                    response.Add("data", services);

                    string jsonResponse = JsonConvert.SerializeObject(response);

                    return jsonResponse;
                }
                else
                {
                    response.Add("error", true);
                    response.Add("message", "There is no Service");

                    string jsonResponse = JsonConvert.SerializeObject(response);

                    return jsonResponse;
                }
            }
            catch (Exception ex)
            {

                response.Add("error", true);
                response.Add("message", ex.Message);

                string jsonResponse = JsonConvert.SerializeObject(response);

                return jsonResponse;
            }
        }

        // GET api/<ServiceReqController>/5
        [HttpGet("{userId}")]
        public string Get(int userId)
        {
            try
            {
                var searchResult = services.FirstOrDefault(p => p.UserId == userId);
                if (searchResult != null)
                {
                    response.Add("error", false);
                    response.Add("message", "Servies Fetch");
                    response.Add("data", searchResult);

                    string jsonResponse = JsonConvert.SerializeObject(response);

                    return jsonResponse;
                }
                else
                {
                    response.Add("error", true);
                    response.Add("message", "There is no service avilable");

                    string jsonResponse = JsonConvert.SerializeObject(response);

                    return jsonResponse;
                }

            }
            catch (Exception ex)
            {
                response.Add("error", true);
                response.Add("message", ex.Message);

                string jsonResponse = JsonConvert.SerializeObject(response);

                return jsonResponse;
            }
        }

        // GET api/<ServiceReqController>/5
        [HttpGet("GetByStatus/{status}")]
        public string GetByStatus(string status)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(status);
                System.Diagnostics.Debug.WriteLine("status");
                var searchResult = services.FirstOrDefault(p => p.Status == status);
                if (searchResult != null)
                {
                    response.Add("error", false);
                    response.Add("message", "Servies Fetch");
                    response.Add("data", searchResult);

                    string jsonResponse = JsonConvert.SerializeObject(response);

                    return jsonResponse;
                }
                else
                {
                    response.Add("error", true);
                    response.Add("message", "There is no service avilable");

                    string jsonResponse = JsonConvert.SerializeObject(response);

                    return jsonResponse;
                }

            }
            catch (Exception ex)
            {
                response.Add("error", true);
                response.Add("message", ex.Message);

                string jsonResponse = JsonConvert.SerializeObject(response);

                return jsonResponse;
            }
        }

        // POST api/<ServiceReqController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ServiceReqController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServiceReqController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
