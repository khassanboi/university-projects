using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace RightJob.DAL
{
    public class TestManager : DbManager
    {
        public void Create(Test t)
        {
            var connection = Connection;
            try
            {
                var sql = $"INSERT INTO ts_test (ts_name_9115) VALUES ('{t.TestName}')";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            /*A method to create new Test and push to the DB*/
        }

        public void Update(Test t)
        {
            var connection = Connection;
            try
            {
                var sql = $"UPDATE ts_test SET ts_name_9115 = '{t.TestName}', ts_questions_number_9115 = '{t.QuestionsNumber}' WHERE ts_id_9115 = { t.Id }";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            /*A method to update an existing Test in the DB*/
        }

        public void UpdateQuestionsNumber(Test t)
        {
            var connection = Connection;
            try
            {
                var sql = $"UPDATE ts_test SET ts_questions_number_9115 = '{t.QuestionsNumber}' WHERE ts_id_9115 = { t.Id }";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            /*A method to update the number of hosted questions of an existing Test in the DB*/
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM ts_test WHERE ts_id_9115 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            /*A method to delete an existing Test in the DB*/
        }

        public Test GetByName(string name)
        {
            var connection = Connection;
            try
            {
                var sql = $"SELECT ts_id_9115, ts_name_9115, ts_questions_number_9115 FROM ts_test WHERE ts_name_9115 = '{name}'";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var t = GetFromReader(reader);
                    return t;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return null;

            /*A method which returns a selected Test item from DB with the TestName*/
        }

        public Test GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $" SELECT ts_id_9115, ts_name_9115, ts_questions_number_9115 FROM ts_test WHERE ts_id_9115 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var t = GetFromReader(reader);
                    return t;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return null;

            /*A method which returns a selected Test item from DB with the ID number*/
        }

        public List<Test> GetAll()
        {
            var connection = Connection;
            var result = new List<Test>();
            try
            {
                var sql = "SELECT ts_id_9115, ts_name_9115, ts_questions_number_9115 FROM ts_test";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var t = GetFromReader(reader);
                    result.Add(t);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;

            /*A method which returns all Tests from DB*/
        }

        private Test GetFromReader(SqlCeDataReader reader)
        {
            var t = new Test
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                TestName = reader.GetValue(1).ToString(),
                QuestionsNumber = Convert.ToInt32(reader.GetValue(2))
            };

            return t;

            /*A method which sets the values of particular properties used in the methods above*/
        }
    }
}
