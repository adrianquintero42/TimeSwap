using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using TimeSwap.Model;

namespace TimeSwap.DAL
{
    public class ServicesStatements
    {
        private Connection _connection;

        public ServicesStatements()
        {
            _connection = new Connection();
            _connection.OpenConnection();
        }

        /**
         * Inserta un nuevo anuncio en la tabla Servicios
         */
        public void NewService(Service service, int userID)
        {
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string insertComand = @"INSERT INTO Servicios (titulo, descripcion_servicio, duracion_servicio, recurrente, RIDS_usuario) 
                        VALUES (@title, @descriptionService, @durationService, @type, @userID)";

                try
                {
                    SqlCommand cmd = new SqlCommand(insertComand, _connection.SqlConnection);

                    SqlParameter titleParam = new SqlParameter("@title", SqlDbType.VarChar, 50);
                    titleParam.Value = service.Title;

                    SqlParameter descriptionServiceParam = new SqlParameter("@descriptionService", SqlDbType.VarChar, 300);
                    descriptionServiceParam.Value = service.DescriptionService;

                    SqlParameter durationServiceParam = new SqlParameter("@durationService", SqlDbType.SmallInt);
                    durationServiceParam.Value = service.DurationService;

                    SqlParameter typeParam = new SqlParameter("@type", SqlDbType.Bit);
                    typeParam.Value = service.TypeService;

                    SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                    userIDParam.Value = userID;

                    cmd.Parameters.Add(titleParam);
                    cmd.Parameters.Add(descriptionServiceParam);
                    cmd.Parameters.Add(durationServiceParam);
                    cmd.Parameters.Add(typeParam);
                    cmd.Parameters.Add(userIDParam);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }

        /**
         * Busca y devuelve una lista con todas las publicaciones almacenadas en la base de datos que no pertenezcan al usuario activo
         */
        public List<Service> SelectServices(int userID)
        {
            List<Service> itemsServices = new List<Service>();

            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string selectComand = "SELECT * FROM Servicios INNER JOIN Usuarios ON RIDS_usuario = id_usuario WHERE RIDS_usuario != @userID AND peticion_activa = 0";

                try
                {
                    SqlCommand cmd = new SqlCommand(selectComand, _connection.SqlConnection);


                    SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                    userIDParam.Value = userID;

                    cmd.Parameters.Add(userIDParam);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Service s = new Service();

                        s.Title = dataReader.GetString(dataReader.GetOrdinal("titulo"));
                        s.DescriptionService = dataReader.GetString(dataReader.GetOrdinal("descripcion_servicio"));
                        s.DurationService = dataReader.GetInt16(dataReader.GetOrdinal("duracion_servicio"));
                        s.ServiceUser = dataReader.GetString(dataReader.GetOrdinal("nombre"));
                        s.UserImg = dataReader.GetString(dataReader.GetOrdinal("foto_perfil"));
                        s.UserPhone = dataReader.GetString(dataReader.GetOrdinal("telefono"));
                        /* Campos ocultos */
                        s.Id = dataReader.GetInt32(dataReader.GetOrdinal("id_servicio"));
                        s.RIdUser = dataReader.GetInt32(dataReader.GetOrdinal("RIDS_usuario"));
                        /*s.TypeService = dataReader.GetInt16(dataReader.GetOrdinal("recurrente"));*/

                        itemsServices.Add(s);
                    }

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return itemsServices;
        }


        /**
         * Busca y devuelve una lista con todas las publicaciones almacenadas en la base de datos que pertenecen al usuario activo
         */
        public List<Service> SelectServicesByID(int userID)
        {
            List<Service> itemsServices = new List<Service>();

            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string selectComand = "SELECT * FROM Servicios INNER JOIN Usuarios ON RIDS_usuario = id_usuario WHERE RIDS_usuario = @userID AND peticion_activa = 0";

                try
                {
                    SqlCommand cmd = new SqlCommand(selectComand, _connection.SqlConnection);
                    SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                    userIDParam.Value = userID;

                    cmd.Parameters.Add(userIDParam);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Service s = new Service();

                        s.Title = dataReader.GetString(dataReader.GetOrdinal("titulo"));
                        s.DescriptionService = dataReader.GetString(dataReader.GetOrdinal("descripcion_servicio"));
                        s.DurationService = dataReader.GetInt16(dataReader.GetOrdinal("duracion_servicio"));
                        s.ServiceUser = dataReader.GetString(dataReader.GetOrdinal("nombre"));
                        if (!dataReader.IsDBNull(dataReader.GetOrdinal("foto_perfil")))
                            s.UserImg = dataReader.GetString(dataReader.GetOrdinal("foto_perfil"));
                        else
                            s.UserImg = "";
                        /* Campos ocultos */
                        s.Id = dataReader.GetInt32(dataReader.GetOrdinal("id_servicio"));
                        s.RIdUser = dataReader.GetInt32(dataReader.GetOrdinal("RIDS_usuario"));
                        itemsServices.Add(s);
                    }

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return itemsServices;
        }


        /**
         * Cambia el estado de un servicio de disponible, a cerrado cuando un usuario ha realizado dicho servicio
         */
        public void UptadeServiceState(int serviceID)
        {
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string upadteComand = @"UPDATE Servicios SET peticion_activa = 1 WHERE id_servicio = @serviceID";
                try
                {
                    SqlCommand cmd = new SqlCommand(upadteComand, _connection.SqlConnection);

                    SqlParameter serviceIDParam = new SqlParameter("@serviceID", SqlDbType.Int);
                    serviceIDParam.Value = serviceID;

                    cmd.Parameters.Add(serviceIDParam);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /**
         * Busca y devuelve la duración de un servicio perteneciente a un usuario
         */
        public int GetServiceDuration(int userID, int serviceID)
        {
            string getDurationSelect = "SELECT duracion_servicio FROM Servicios WHERE RIDS_usuario = @userID AND id_servicio = @serviceID";
            int duration = 0;

            SqlCommand sqlCommand = new SqlCommand(getDurationSelect, _connection.SqlConnection);

            SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
            userIDParam.Value = userID;

            SqlParameter serviceIDParam = new SqlParameter("@serviceID", SqlDbType.Int);
            serviceIDParam.Value = serviceID;

            sqlCommand.Parameters.Add(userIDParam);
            sqlCommand.Parameters.Add(serviceIDParam);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.Read())
            {
                duration = dataReader.GetInt16(dataReader.GetOrdinal("duracion_servicio"));
            }

            return duration;
        }
    }
}