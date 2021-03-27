using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    public class Test
    {
        private string _testName;

        public int Id { get; set; }

        public string TestName
        {
            get => _testName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Test Name cannot be empty!");
                _testName = value;

                /*validating TestName and throwing an exception message*/
            }
        }

        public int QuestionsNumber { get; set; }

        public Test()
        {
            QuestionsNumber = 0;

            /*Setting a default number of questions upon creating a new test*/
        }

        public override string ToString()
        {
            return TestName;
        }

        public Test(int id, string testName, int questionsNumber)
        {
            Id = id;
            TestName = testName;
            QuestionsNumber = questionsNumber;
        }
    }
}
