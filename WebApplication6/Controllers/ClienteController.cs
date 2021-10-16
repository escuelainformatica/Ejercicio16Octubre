using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.dto;
using WebApplication6.Models;
using WebApplication6.repo;

namespace WebApplication6.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Listar()
        {
            List<Cliente> clientes=ClienteRepo.Listar();

            List<ClienteDto> clientesdto=new List<ClienteDto>();
            // transformo los clientes
            foreach(var cliente in clientes)
            {
                var clienteDto=new ClienteDto();
                clienteDto.IdCliente=cliente.IdCliente;
                clienteDto.NombreCompleto=cliente.Nombre+" "+cliente.Apellido;
                clientesdto.Add(clienteDto);
            }
            return View(clientesdto); // enviando datos por el modelo
        }




    }
}
