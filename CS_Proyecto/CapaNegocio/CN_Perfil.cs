using CS_Proyecto.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaNegocio
{
    internal class CN_Perfil
    {
        CD_Perfil cD_Perfil = new CD_Perfil();
        public void EditarPerfil(int IdUsuario, string Nombres, string Apellidos, string Genero, string Dui, string NombreUsuario, string Contrasena, byte[] Imagen, string correo, int IdRol, int IdTipoEstado)
        {
            cD_Perfil.ModificarPerfil(IdUsuario, Nombres, Apellidos, Genero, Dui, NombreUsuario, Contrasena, Imagen, correo, IdRol, IdTipoEstado);
        }

        public void EncriptarContrasena(string Contrasena, string NombreUsuario)
        {
            cD_Perfil.ModificarPerfil(Contrasena, NombreUsuario);
        }
    }

}
