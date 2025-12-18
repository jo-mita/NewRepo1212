using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Ejemplo2.Modelos;

namespace Ejemplo2.Datos
{
    public class ContactoDatos
    {
        // Cadena de conexión desde App.config
        private readonly string cadena =
            ConfigurationManager.ConnectionStrings["ConexionAgenda"].ConnectionString;

        // ==========================
        // GUARDAR CONTACTO
        // ==========================
        public void Guardar(Contacto contacto)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string sql = @"
                    INSERT INTO Contactos
                    (Nombre, Telefono, Direccion, Instagram, Facebook, LinkedIn)
                    VALUES
                    (@Nombre, @Telefono, @Direccion, @Instagram, @Facebook, @LinkedIn)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", contacto.Direccion);
                    cmd.Parameters.AddWithValue("@Instagram", contacto.Instagram);
                    cmd.Parameters.AddWithValue("@Facebook", contacto.Facebook);
                    cmd.Parameters.AddWithValue("@LinkedIn", contacto.LinkedIn);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==========================
        // LISTAR CONTACTOS
        // ==========================
        public List<Contacto> Listar()
        {
            List<Contacto> lista = new List<Contacto>();

            using (SqlConnection con = new SqlConnection(cadena))
            {
                string sql = "SELECT * FROM Contactos";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(MapearContacto(dr));
                        }
                    }
                }
            }
            return lista;
        }

        // ==========================
        // BUSCAR CONTACTO POR NOMBRE
        // ==========================
        public List<Contacto> Buscar(string nombre)
        {
            List<Contacto> lista = new List<Contacto>();

            using (SqlConnection con = new SqlConnection(cadena))
            {
                string sql = "SELECT * FROM Contactos WHERE Nombre LIKE @Nombre";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(MapearContacto(dr));
                        }
                    }
                }
            }
            return lista;
        }

        // ==========================
        // MÉTODO PRIVADO DE APOYO
        // ==========================
        private Contacto MapearContacto(SqlDataReader dr)
        {
            return new Contacto
            {
                Id = (int)dr["Id"],
                Nombre = dr["Nombre"].ToString(),
                Telefono = dr["Telefono"].ToString(),
                Direccion = dr["Direccion"].ToString(),
                Instagram = dr["Instagram"].ToString(),
                Facebook = dr["Facebook"].ToString(),
                LinkedIn = dr["LinkedIn"].ToString()
            };
        }
    }
}
