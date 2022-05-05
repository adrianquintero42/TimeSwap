using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TimeSwap.Model;


namespace TimeSwap.DAL
{
    public class UsersStatements
    {
        private Connection _connection;
        private const String KEY = "b14ca5898a4e4133bbce2ea2315a1916";
        public UsersStatements()
        {
            _connection = new Connection();
            _connection.OpenConnection();
        }


        /**
         * Comprueba si el correo electronico existe y devuelve un objeto User con todos los datos
         */
        public User CheckUserAndGetData(String email)
        {
            User user = new User();
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {

                string query = "SELECT * FROM Usuarios WHERE email = @mail";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _connection.SqlConnection);

                    SqlParameter mailParam = new SqlParameter("@mail", SqlDbType.VarChar, 50);
                    mailParam.Value = email;

                    cmd.Parameters.Add(mailParam);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {

                        user.Email = email;
                        user.Id = dataReader.GetInt32(dataReader.GetOrdinal("id_usuario"));
                        user.Password = AesOperation.DecryptString(KEY, dataReader.GetString(dataReader.GetOrdinal("contrasenya")));
                        user.FirstName = dataReader.GetString(dataReader.GetOrdinal("nombre"));
                        user.LastName = dataReader.GetString(dataReader.GetOrdinal("apellidos"));
                        user.Phone = dataReader.GetString(dataReader.GetOrdinal("telefono"));
                        user.Birthday = dataReader.GetDateTime(dataReader.GetOrdinal("fecha_nacimiento"));
                        user.EarnedHours = dataReader.GetInt16(dataReader.GetOrdinal("horas_ganadas"));
                        user.SpentHours = dataReader.GetInt16(dataReader.GetOrdinal("horas_gastadas"));
                        user.Balance = dataReader.GetInt16(dataReader.GetOrdinal("saldo"));
                        user.PerformedServices = dataReader.GetInt16(dataReader.GetOrdinal("servicios_realizados"));
                        user.RecievedServices = dataReader.GetInt16(dataReader.GetOrdinal("servicios_recibidos"));

                        if (!dataReader.IsDBNull(dataReader.GetOrdinal("foto_perfil")))
                            user.Image = dataReader.GetString(dataReader.GetOrdinal("foto_perfil"));
                        else user.Image = "";

                    }
                    dataReader.Close();

                } catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return user;
        }

        /**
         * Introduce un nuevo usuario en la base de datos
         */
        public void RegisterNewUser(User user)
        {
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string query = "SELECT * FROM Usuarios WHERE email = @mail";

                string insertComand = @"INSERT INTO Usuarios (email, contrasenya, nombre, apellidos, fecha_nacimiento, telefono, 
                                        horas_ganadas, horas_gastadas, saldo, servicios_realizados, servicios_recibidos)
                                        VALUES (@mail, @pass, @firstName, @lastName, @birthday, @phone, @earnedHours,
                                        @spentHours, @balance, @performedServices, @recievedServicies)";
                try
                {

                    SqlCommand sqlCommand = new SqlCommand(query, _connection.SqlConnection);

                    SqlParameter mailP = new SqlParameter("@mail", SqlDbType.VarChar, 50);
                    mailP.Value = user.Email;

                    sqlCommand.Parameters.Add(mailP);

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    if (!dataReader.Read()) 
                    {
                        dataReader.Close();
                        SqlCommand cmd = new SqlCommand(insertComand, _connection.SqlConnection);
                        SqlParameter mailParam = new SqlParameter("@mail", SqlDbType.VarChar, 50);
                        mailParam.Value = user.Email;

                        SqlParameter passParam = new SqlParameter("@pass", SqlDbType.VarChar, 100);
                        passParam.Value = AesOperation.EncryptString(KEY, user.Password);

                        SqlParameter firstNameParam = new SqlParameter("@firstName", SqlDbType.VarChar, 50);
                        firstNameParam.Value = user.FirstName;

                        SqlParameter lastNameParam = new SqlParameter("@lastName", SqlDbType.VarChar, 50);
                        lastNameParam.Value = user.LastName;

                        SqlParameter birthdayParam = new SqlParameter("@birthday", SqlDbType.Date);
                        birthdayParam.Value = user.Birthday;

                        SqlParameter phoneParam = new SqlParameter("@phone", SqlDbType.VarChar, 15);
                        phoneParam.Value = user.Phone;

                        SqlParameter earnerHParam = new SqlParameter("@earnedHours", SqlDbType.SmallInt);
                        earnerHParam.Value = 0;

                        SqlParameter spentHParamas = new SqlParameter("@spentHours", SqlDbType.SmallInt);
                        spentHParamas.Value = 0;

                        SqlParameter balanceParam = new SqlParameter("@balance", SqlDbType.SmallInt);
                        balanceParam.Value = 5;

                        SqlParameter performedServicesParam = new SqlParameter("@performedServices", SqlDbType.SmallInt);
                        performedServicesParam.Value = 0;

                        SqlParameter recievedServicesParam = new SqlParameter("@recievedServicies", SqlDbType.SmallInt);
                        recievedServicesParam.Value = 0;

                        cmd.Parameters.Add(mailParam);
                        cmd.Parameters.Add(passParam);
                        cmd.Parameters.Add(firstNameParam);
                        cmd.Parameters.Add(lastNameParam);
                        cmd.Parameters.Add(birthdayParam);
                        cmd.Parameters.Add(phoneParam);
                        cmd.Parameters.Add(earnerHParam);
                        cmd.Parameters.Add(spentHParamas);
                        cmd.Parameters.Add(balanceParam);
                        cmd.Parameters.Add(performedServicesParam);
                        cmd.Parameters.Add(recievedServicesParam);

                        cmd.ExecuteNonQuery();
                    } else
                    {
                        dataReader.Close();
                        Console.WriteLine("El usuario ya existe");
                    }
                } catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /**
         * Actualiza la información personal del usuario
         */

        public void UptadeUserInformation(User user)
        {
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string upadteComand = @"UPDATE Usuarios SET nombre = @firstName, email = @mail,
                                        apellidos = @lastName, fecha_nacimiento = @birthday, telefono = @phone, 
                                        foto_perfil = @image WHERE id_usuario = @userID";
                try
                {
                    SqlCommand cmd = new SqlCommand(upadteComand, _connection.SqlConnection);

                    SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                    userIDParam.Value = user.Id;

                    SqlParameter mailParam = new SqlParameter("@mail", SqlDbType.VarChar, 50);
                    mailParam.Value = user.Email;

                    SqlParameter firstNameParam = new SqlParameter("@firstName", SqlDbType.VarChar, 50);
                    firstNameParam.Value = user.FirstName;

                    SqlParameter lastNameParam = new SqlParameter("@lastName", SqlDbType.VarChar, 50);
                    lastNameParam.Value = user.LastName;

                    SqlParameter birthdayParam = new SqlParameter("@birthday", SqlDbType.Date);
                    birthdayParam.Value = user.Birthday;

                    SqlParameter phoneParam = new SqlParameter("@phone", SqlDbType.VarChar, 15);
                    phoneParam.Value = user.Phone;

                    SqlParameter imageRouteParam = new SqlParameter("@image", SqlDbType.VarChar, 100);
                    imageRouteParam.Value = user.Image;

                    cmd.Parameters.Add(userIDParam);
                    cmd.Parameters.Add(mailParam);
                    cmd.Parameters.Add(firstNameParam);
                    cmd.Parameters.Add(lastNameParam);
                    cmd.Parameters.Add(birthdayParam);
                    cmd.Parameters.Add(phoneParam);
                    cmd.Parameters.AddWithValue("image", imageRouteParam.Value ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /**
         * Actualiza la contraseña del usuario
         */
        public void ChangePassword(int userID, string newPassword)
        {
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string upadteComand = @"UPDATE Usuarios SET contrasenya = @pass WHERE id_usuario = @userID";
                try
                {
                    SqlCommand cmd = new SqlCommand(upadteComand, _connection.SqlConnection);
                    SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                    userIDParam.Value = userID;

                    SqlParameter passParam = new SqlParameter("@pass", SqlDbType.VarChar, 100);
                    passParam.Value = AesOperation.EncryptString(KEY, newPassword);

                    cmd.Parameters.Add(userIDParam);
                    cmd.Parameters.Add(passParam);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /**
         * Elimina un usuario
         */
        public void DeleteUser(User user)
        {
            string deleteCommand = "DELETE FROM Usuarios WHERE id_usuario = @userID";
            try
            {
                SqlCommand cmd = new SqlCommand(deleteCommand, _connection.SqlConnection);
                SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                userIDParam.Value = user.Id;

                cmd.Parameters.Add(userIDParam);

                cmd.ExecuteNonQuery();

            } catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /**
         * Busca y devuelve la ID de un usuario deseado
         */
        public int SearchUser(string email)
        {
            int userID = 0;
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                string query = "SELECT * FROM Usuarios WHERE email = @mail";
                try
                {
                    SqlCommand cmd = new SqlCommand(query, _connection.SqlConnection);

                    SqlParameter mailParam = new SqlParameter("@mail", SqlDbType.VarChar, 50);
                    mailParam.Value = email;

                    cmd.Parameters.Add(mailParam);

                    SqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {

                        userID = dataReader.GetInt32(dataReader.GetOrdinal("id_usuario"));

                    }
                    dataReader.Close();

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return userID;
        }


        /**
         * Actualiza el saldo y el número de servicios de los usuarios tras cerrar una publicación
         */
        public void UpdateUserServiceData(int userID, int actualUserID, int serviceID, ServicesStatements servicesStatements)
        {
            if (_connection.SqlConnection.State != ConnectionState.Closed)
            {
                int duration = servicesStatements.GetServiceDuration(actualUserID, serviceID);


                string otherUserUpdateCmd = @"UPDATE Usuarios SET horas_ganadas = 
                                            (horas_ganadas + " + duration + "), " +
                                            "saldo = (saldo + " + duration + "), " +
                                            "servicios_realizados = (servicios_realizados + 1) " +
                                            "WHERE id_usuario = @userID";
                string actualUserUpdateCmd = @"UPDATE Usuarios SET horas_gastadas = (horas_gastadas + " + duration + "), " +
                                            "saldo = (saldo - " + duration + "), " +
                                            "servicios_recibidos = (servicios_recibidos + 1) " +
                                            "WHERE id_usuario = @actualUserID";
                try
                {
                    SqlCommand cmd = new SqlCommand(otherUserUpdateCmd, _connection.SqlConnection);

                    SqlParameter userIDParam = new SqlParameter("@userID", SqlDbType.Int);
                    userIDParam.Value = userID;

                    cmd.Parameters.Add(userIDParam);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand(actualUserUpdateCmd, _connection.SqlConnection);

                    SqlParameter actualUserIDParam = new SqlParameter("@actualUserID", SqlDbType.Int);
                    actualUserIDParam.Value = actualUserID;

                    cmd.Parameters.Add(actualUserIDParam);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}