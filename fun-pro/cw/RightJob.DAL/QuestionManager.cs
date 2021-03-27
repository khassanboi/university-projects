using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightJob.DAL
{
    public class QuestionManager : DbManager
    {
        public void Create(Test t, Question q)
        {
            var connection = Connection;
            try
            {
                var sql = $"INSERT INTO qs_question (qs_test_id_9115, qs_question_9115, qs_answer_9115) VALUES ('{t.Id}', '{q.QuestionText}', '{q.Answer}')";
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

            /*A method to create new Question and push to the DB*/
            /*It receives two arguments: Test and Question which helps to set value to qs_test_id_9115 column properly*/
        }

        public void Update(Question q)
        {
            var connection = Connection;
            try
            {
                var sql = $@"UPDATE qs_question SET 
                                    qs_question_9115 = '{q.QuestionText}', 
                                    qs_answer_9115 = '{q.Answer}'
                             WHERE qs_id_9115 = { q.Id }";
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

            /*A method to update an existing Question in the DB*/
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"DELETE FROM qs_question WHERE qs_id_9115 = {id}";
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

            /*A method to delete an existing Question in the DB*/
        }

        public void DeleteWithTest(int testId)
        {
            var connection = Connection;
            try
            {
                var sql = $@"DELETE FROM qs_question WHERE qs_test_id_9115 = {testId}";
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

            /*A method to delete an existing Question in the DB*/
        }

        public List<Question> GetAll()
        {
            var connection = Connection;
            var result = new List<Question>();
            try
            {
                var sql = "SELECT qs_id_9115, qs_test_id_9115, qs_question_9115, qs_answer_9115 FROM qs_question";
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

            /*A method which returns all Questions from DB*/
        }

        public List<Question> GetByTestId(int id)
        {
            var connection = Connection;
            var result = new List<Question>();
            try
            {
                var sql = $"SELECT * FROM qs_question WHERE qs_test_id_9115 = '{id}'";
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

            /*A method which returns a list of Questions from DB with given TestId*/
        }

        private Question GetFromReader(SqlCeDataReader reader)
        {
            var q = new Question
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                TestId = Convert.ToInt32(reader.GetValue(1)),
                TestName = new TestManager().GetById(Convert.ToInt32(reader.GetValue(1))).TestName,
                QuestionText = reader.GetValue(2).ToString(),
                Answer = reader.GetValue(3).ToString(),
            };

            return q;

            /*A method which sets the values of particular properties used in the methods above*/
        }
    }
}
