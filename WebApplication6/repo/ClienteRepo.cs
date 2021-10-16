using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.repo
{
    // repo  InsertarPagos, CancelarCuenta
    // dao  Insertar,    Actualizar


    public class ClienteRepo // dao
    {
        public static List<Cliente> Listar()
        {
            var resultado=new List<Cliente>();
            resultado.Add(new Cliente { IdCliente = 1, Nombre = "John", Apellido = "Doe"});
            resultado.Add(new Cliente { IdCliente = 2, Nombre = "Anna", Apellido = "Smith" });

            return resultado;
        }
    }
}
