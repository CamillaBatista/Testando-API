using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testeApi.Models;

namespace testeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public List<Cliente> Get()
        {
            return clientes;
        }

        [HttpPost]
        public void Post(string nome)
        {
            clientes.Add(new Cliente(nome));
        }
    }
}