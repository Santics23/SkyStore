﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Entidades
{
    public class ClUsuarioE : ClRolE
    {
        public int idUsuario { get; set; }
        public string documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string clave { get; set; }
    }
}