using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.Entities
{
    public class EmpresaPessoaEntity
    {
        public EmpresaEntity codpessoaEmpresa { get; set; }
        public PessoaEntity codEmpresapessoa { get; set; }
        public double codExpectativa { get; set; }

        public EmpresaPessoaEntity()
        {

        }
    }
}