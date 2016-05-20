﻿using SuperERP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperERP.Compras.Dto
{
    class UsuarioDto
    {
        public int ID { get; set; }
        public int ID_Perfil { get; set; }
        public int ID_Empresa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public  Empresa Empresa { get; set; }
        public  Perfil Perfil { get; set; }

    }
}
