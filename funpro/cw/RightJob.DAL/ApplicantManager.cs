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
    public class ApplicantManager : DbManager
    {
        public void Create(Applicant a)
        {
            var connection = Connection;
            try
            {
                var sql = $"INSERT INTO ap_applicant (ap_name_9115, ap_score_9115, ap_tests_taken_9115) VALUES ('{a.Name}', '{a.Score}', '{a.TestsTaken}')";
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

            /*A method to create new Applicant and push to the DB*/
        }

        public void Update(Applicant a)
        {
            var connection = Connection;
            try
            {
                var sql = $@"UPDATE ap_applicant SET 
                                    ap_name_9115 = '{a.Name}', 
                                    ap_score_9115 = '{a.Score}', 
                                    ap_tests_taken_9115 = '{a.TestsTaken}' 
                             WHERE ap_id_9115 = {a.Id}";
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

            /*A method to update an existing Applicant in the DB*/
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM ap_applicant WHERE ap_id_9115 = {id}";
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

            /*A method to delete an existing Applicant in the DB*/
        }

        public List<Applicant> GetAll()
        {
            var connection = Connection;
            var result = new List<Applicant>();
            try
            {
                var sql = "SELECT ap_id_9115, ap_name_9115, ap_score_9115, ap_tests_taken_9115 FROM ap_applicant";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
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

            /*A method which returns all Applicants from DB*/
        }

        private Applicant GetFromReader(SqlCeDataReader reader)
        {
            var a = new Applicant
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = reader.GetValue(1).ToString(),
                Score = Convert.ToInt32(reader.GetValue(2)),
                TestsTaken = reader.GetValue(3).ToString()
            };

            return a;

            /*A method which sets the values of particular properties used in the methods above*/
        }
    }
}
