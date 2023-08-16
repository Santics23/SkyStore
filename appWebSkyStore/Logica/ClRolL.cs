using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Logica
{
    public class ClRolL
    {
        public List<ClRolE> mtdListar()
        {
            ClRolD objRol = new ClRolD();
            List<ClRolE> listaRoles = objRol.mtdListar();
            return listaRoles;
        }
    }
}