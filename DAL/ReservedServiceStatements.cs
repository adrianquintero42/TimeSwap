using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TimeSwap.Model;

namespace TimeSwap.DAL
{
    public class ReservedServiceStatements
    {
        private Connection _connection;
        public ReservedServiceStatements()
        {
            _connection = new Connection();
            _connection.OpenConnection();
        }


        /**
         * Inserta un anuncio cerrada en la tabla Servicios_Reservados
         */
        public void InsertNewClosedService(DateTime date, int serviceID, int userID, int actualUserID)
        {
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {

                string insertComand = @"INSERT INTO Servicios_Reservados (fecha_reserva, RIDSR_servicio, RIDSR_usuario, id_usuario_actual) VALUES (@date, @serviceID, @userID, @actualUser)";
                try
                {

                    SqlCommand cmd = new SqlCommand(insertComand, _connection.SqlConnection);

                    SqlParameter dateParam = new SqlParameter("@date", SqlDbType.Date);
                    dateParam.Value = date;

                    SqlParameter serviceIDParam = new SqlParameter("@serviceID", SqlDbType.Int);
                    serviceIDParam.Value = serviceID;

                    SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                    userIDParam.Value = userID;

                    SqlParameter actualUserIDParam = new SqlParameter("@actualUser", SqlDbType.Int);
                    actualUserIDParam.Value = actualUserID;

                    cmd.Parameters.Add(dateParam);
                    cmd.Parameters.Add(serviceIDParam);
                    cmd.Parameters.Add(userIDParam);                    
                    cmd.Parameters.Add(actualUserIDParam);

                    cmd.ExecuteNonQuery();
                    
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /**
         * Busca y devuelve una lista con todos los servicios cerrados del usuario
         */
        public List<ReservedServicies> SelectClosedServices(User user)
        {
            List<ReservedServicies> serviciosReservados = new List<ReservedServicies>();

            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string query = @"SELECT * FROM Servicios_Reservados INNER JOIN Servicios ON
                                RIDSR_servicio = id_servicio INNER JOIN Usuarios ON RIDSR_usuario = id_usuario WHERE id_usuario_actual = @userID";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _connection.SqlConnection);

                    SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                    userIDParam.Value = user.Id;

                    cmd.Parameters.Add(userIDParam);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {

                        ReservedServicies reserved = new ReservedServicies
                        {
                            Title = dataReader.GetString(dataReader.GetOrdinal("titulo")),
                            Duration = dataReader.GetInt16(dataReader.GetOrdinal("duracion_servicio")),
                            ReservationDate = dataReader.GetDateTime(dataReader.GetOrdinal("fecha_reserva")),
                            UserRes = dataReader.GetString(dataReader.GetOrdinal("nombre"))
                        };

                        serviciosReservados.Add(reserved);

                    }
                    dataReader.Close();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return serviciosReservados;
        }        
    }
}