using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    public class Question
    {
        private string _testName;
        private string _questionText;
        private string _answer;

        public int Id { get; set; }

        public int TestId { get; set; }

        public string TestName
        {
            get => _testName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Test Name cannot be empty!");
                _testName = value;

                /*validating Question and throwing an exception message*/
            }
        }
        
        public string QuestionText
        {
            get => _questionText;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Question cannot be empty!");
                _questionText = value;

                /*validating Question and throwing an exception message*/
            }
        }

        public string Answer
        {
            get => _answer;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Answer cannot be empty!");
                _answer = value;

                /*validating Answer and throwing an exception message*/
            }
        }

        public Question()
        {

        }

        public Question(int id, int testId, string testName, string question, string answer)
        {
            Id = id;
            TestId = testId;
            TestName = testName;
            QuestionText = question;
            Answer = answer;
        }
    }
}
