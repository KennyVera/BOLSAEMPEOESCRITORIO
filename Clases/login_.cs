using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace REDEMPLEO
{
    public class login_
    {
        private ConexionBD conexion = new ConexionBD();

        public string GenerarXMLCandidato(string email,string contrasena, string nombre, string apellido,string telefono, string fechaNacimiento,string resumen)
        {
            string xml = "";
            xml += "<Candidatos>";
            xml += "   <Item>";
            xml += "       <Email>" + email + "</Email>";
            xml += "       <Contrasena>" + contrasena + "</Contrasena>";
            xml += "       <Nombre>" + nombre + "</Nombre>";
            xml += "       <Apellido>" + apellido + "</Apellido>";
            xml += "       <Telefono>" + telefono + "</Telefono>";
            xml += "       <FechaNacimiento>" + fechaNacimiento + "</FechaNacimiento>";
            xml += "       <Resumen>" + resumen + "</Resumen>";
            xml += "   </Item>";
            xml += "</Candidatos>";

            return xml;
        }

        public string GenerarXMLEmpresa(string email, string contrasena, string nombreEmpresa, string ruc, string direccion, string sitioWeb, string correoContacto, string descripcion)
        {
            string xml = "";
            xml += "<Empresas>";
            xml += "   <Item>";
            xml += "       <Email>" + email + "</Email>";
            xml += "       <Contrasena>" + contrasena + "</Contrasena>";
            xml += "       <NombreEmpresa>" + nombreEmpresa + "</NombreEmpresa>";
            xml += "       <RUC>" + ruc + "</RUC>";
            xml += "       <Direccion>" + direccion + "</Direccion>";
            xml += "       <SitioWeb>" + sitioWeb + "</SitioWeb>";
            xml += "       <CorreoContacto>" + correoContacto + "</CorreoContacto>";
            xml += "       <Descripcion>" + descripcion + "</Descripcion>";
            xml += "   </Item>";
            xml += "</Empresas>";

            return xml;
        }

        public bool InsertarCandidatoXML(string xml)
        {
            try
            {
                SqlConnection con = conexion.AbrirConexion();
                SqlCommand cmd = new SqlCommand("PA_insertarCandidatos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@XmlData", SqlDbType.Xml).Value = xml;
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool InsertarEmpresaXML(string xml)
        {
            try
            {
                SqlConnection con = conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("PA_insertarEmpresas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@XmlData", SqlDbType.Xml).Value = xml;
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public string RolObtenido = "";
        public bool VerificarCredenciales(string usuario, string contraseña)
        {
            try
            {
                SqlConnection con = conexion.AbrirConexion();

                string query = $"SELECT Rol FROM Cuenta WHERE Email = '{usuario}' AND Contrasena = '{contraseña}'";
                SqlCommand cmd = new SqlCommand(query, con);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    RolObtenido = result.ToString();  // Guardamos el rol
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar credenciales: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
