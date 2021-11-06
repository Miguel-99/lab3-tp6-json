using lab3_tp6_json.model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_tp6_json {
    class Gestor: Conexion{
        public List<Author> getAllEscritores() {
            MySqlDataReader reader;
            List<Author> escritores = new List<Author>();
            string sql;
            sql = $"SELECT * FROM author ORDER BY id;";

            MySqlConnection conexionDB = null;

            try {
                conexionDB = Conexion.conexion();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Author escritor = new Author();
                    escritor.Id = reader.GetInt32("id");
                    escritor.Apellido = reader.GetString("apellido");
                    escritor.Nombre = reader.GetString("nombre");
                    escritor.Dni = reader.GetInt32("dni");
                    escritor.Libros = getAllLibrosFromEscritor(reader.GetInt32("id"));

                    escritores.Add(escritor);
                }
            } catch (MySqlException ex) {
                Console.WriteLine(ex.Message.ToString());
            } finally {
                conexionDB.Close();
            }
            return escritores;
        }
        public List<Book> getAllLibrosFromEscritor(int idEscritor) {
            MySqlDataReader reader;
            List<Book> libros = new List<Book>();
            string sql;
            sql = $"SELECT * FROM book where idEscritor={idEscritor};";
            MySqlConnection conexionDB = null;

            try {
                conexionDB = Conexion.conexion();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Book libro = new() {
                        Id = reader.GetInt32("id"),
                        Name = reader.GetString("nombre"),
                        Anio_publicacion = reader.GetInt32("anio_publicacion"),
                        Editorial = reader.GetString("editorial"),
                        IdAuthor = reader.GetInt32("idEscritor")
                    };

                    libros.Add(libro);
                }
            } catch (MySqlException ex) {
                Console.WriteLine(ex.Message.ToString());
            } finally {
                conexionDB.Close();
            }
            return libros;
        }


    }
}
