using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactRouterDemo.Data;
using System.Net;

namespace ReactRouterDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private string _connectionString;

        public PeopleController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }

        [HttpGet]
        [Route("getall")]
        public List<Person> GetAll()
        {
            var repo = new PersonCarsRepository(_connectionString);
            return repo.GetAll();
        }

        [HttpGet]
        [Route("GetHuman")]
        public Human GetHuman()
        {
            return new Human
            {
                Name = "The Human",
                Houses = new List<House> 
                {
                    new House
                    {
                        Address = "123 Foo st",
                        Price = 12334234
                    },
                    new House
                    {
                        Address = "123 Bar st",
                        Price = 2324324
                    }
                }
            };
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public List<House> Houses { get; set; }
    }

    public class House
    {
        public string Address { get; set; }
        public double Price { get; set; }
    }
}
