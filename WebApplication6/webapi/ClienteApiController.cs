using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.dto;
using WebApplication6.Models;
using WebApplication6.repo;

namespace WebApplication6.webapi
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteApiController : ControllerBase
    {
        [Route("Listar")]
        public List<Cliente> Listar()
        {
            return ClienteRepo.Listar();
        }
        [Route("Obtener")]
        public Cliente2Dto Obtener()
        {
            var resultado=new Cliente2Dto();

            resultado.Autor="John";
            resultado.Clientes= ClienteRepo.Listar();
            resultado.Cantidad= resultado.Clientes.Count();
            return resultado;
        }
    }
}
