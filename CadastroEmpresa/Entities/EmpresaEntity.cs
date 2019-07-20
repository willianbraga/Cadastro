using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.Entities
{
    public class EmpresaEntity
    {
        public int codEmpresa { get; set; }
        public string nomEmpresa { get; set; }
        public double fatEmpresa { get; set; }
        public double expEmpresa  { get; set; }
        public EmpresaEntity()
        {

        }
    }


}