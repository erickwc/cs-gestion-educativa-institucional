using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Proyecto.CapaNegocio
{
    internal class CP_Login
    {
        CapaDatos.CD_Login login = new CapaDatos.CD_Login();

        public bool consultaUsuario(string usuario, string contraseña)
        {
            return login.ConsultarUsuario(usuario, contraseña);
        }

        public bool consultaUsuarioEncriptado(string usuario)
        {
            return login.ConsultarUsuarioEncriptado(usuario);
        }
    }
}
