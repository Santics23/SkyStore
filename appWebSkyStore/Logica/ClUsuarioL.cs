﻿using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Logica
{
    public class ClUsuarioL
    {
        public ClUsuarioE mtdLogin(string email, string clave)
        {
            ClUsuarioD ObjUsuarioD = new ClUsuarioD();
            ClUsuarioE DatosUsuario = ObjUsuarioD.mtdLogin(email, clave);
            return DatosUsuario;

        }
        public ClRolUsuarioE mtdLoginrol(int idUsuario)
        {
            ClUsuarioD ObjUsuarioD = new ClUsuarioD();
            ClRolUsuarioE DatosUsuario = ObjUsuarioD.mtdLoginRol(idUsuario);
            return DatosUsuario;

        }

        public int mtdRegistrar(ClUsuarioE objDatos)
        {
            ClUsuarioD objUsuarioD = new ClUsuarioD();
            int reg = objUsuarioD.MtdRegistrar(objDatos);

            return reg;
        }



        public List<ClUsuarioE> mtdListarUsu()
        {
            ClUsuarioD objUsuarioD = new ClUsuarioD();
            List<ClUsuarioE> listarUsu = objUsuarioD.mtdListarUsuario();
            return listarUsu;
        }

        public ClUsuarioE mtdBuscar(string documento)
        {
            ClUsuarioD objUsuarioD = new ClUsuarioD();
            ClUsuarioE objDatos = objUsuarioD.mtdFiltro(documento);
            return objDatos;
        }

        public int mtdValidar(ClUsuarioE objDatos)
        {
            ClUsuarioD objD = new ClUsuarioD();

            int Verificar = objD.mtdVerificarusuario(objDatos);

            return Verificar;

        }
    }
}