using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centros_de_Triaje.Model
{
    public class GlobalVariables
    {
        public static string nivelDeAcceso { get; set; }

        public static void mostrarMensajeBienvenida()
        {
            const string mensaje = "Usuario y contraseña correctos. ¡Bienvenido!";
            const string caption = "Mensaje del sistema";
            var result = MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void mostrarMensajeErrorLogin()
        {
            const string mensaje = "Usuario o contraseña incorrectos. Intentelo de nuevo.";
            const string caption = "Mensaje del sistema";
            var result = MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void mostrarMensajeErrorContrasenia(){
            const string mensaje = "Las contraseñas no coinciden. Verifique sus datos.";
            const string caption = "Mensaje del sistema";
            var result = MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mostrarMensajeErrorVacio()
        {
            const string mensaje = "No se pueden dejar campos vacios. Por favor, ingresa tus datos.";
            const string caption = "Mensaje del sistema";
            var result = MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mostrarMensajeRegistroExitoso()
        {
            const string mensaje = "Registro guardado con éxito.";
            const string caption = "Mensaje del sistema";
            var result = MessageBox.Show(mensaje, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
