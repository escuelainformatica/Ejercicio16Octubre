using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.repo
{
    public class PaisRepo // dao.
    {
        public static List<Pais> Listar() {
            var resultado= new List<Pais>();
            resultado.Add(new Pais { IdPais=1,Nombre="Chile"});
            resultado.Add(new Pais { IdPais = 2, Nombre = "Argentina" });
            //todo: falta conectarse con la base de datos.
            return resultado;
        }
    }
}
