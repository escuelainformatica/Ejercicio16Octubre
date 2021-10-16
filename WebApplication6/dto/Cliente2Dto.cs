using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.dto
{
    public class Cliente2Dto
    {
        public string Autor { set; get;}
        public int Cantidad { set;get;}
        public List<Cliente> Clientes { set; get;}

    }
}
