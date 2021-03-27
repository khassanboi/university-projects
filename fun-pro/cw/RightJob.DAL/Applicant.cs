using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    public class Applicant
    {
        private string _name;
        private int _score;

        public int Id { get; set; }

        public string Name {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be empty!");
                _name = value;

                /*validating Name and throwing an exception message*/
            }
        }

        public int Score {
            get => _score;
            set
            {
                if (value < 0)
                    throw new Exception("There has been an error which cause the Score to contain a negative value. Please, restart the application!");
                _score = value;

                /*validating Score and throwing an exception message*/
            }
        }

        public string TestsTaken { get; set; }

        public Applicant()
        {
            Score = 0;

            /*Setting a default score value upon creating a new applicant*/
        }

        public Applicant(int id, string name, int score, string testsTaken)
        {
            Id = id;
            Name = name;
            Score = score;
            TestsTaken = testsTaken;
        }
    }
}
