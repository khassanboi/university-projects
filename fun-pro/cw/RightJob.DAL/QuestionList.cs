using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    public class QuestionList
    {
        public List<Question> GetAllQuestions()
        {
            return new QuestionManager().GetAll();

            //A method calling a GetAll() method of manager class
        }

        public List<Question> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.TestId:
                    return GetAllQuestions().Where(q => q.TestId.ToString() == value).ToList();
            }

            //when there is an error, program reaches this part
            return null;

            //A method which searches a Question with inserted TestId. It returns a list of questions hosted by the test with inserted ID number.
        }
    }
}
