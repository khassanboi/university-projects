using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    public class ApplicantList
    {
        public List<Applicant> GetAllApplicants()
        {
            return new ApplicantManager().GetAll();

            //A method calling a GetAll() method of manager class
        }

        public List<Applicant> SortLinq(ByAttribute attribute)
        {
            switch (attribute)
            { 
                case ByAttribute.Score:
                    return GetAllApplicants().OrderBy(score => score.Score).ToList();
            }

            //when there is an error, program reaches this part
            return null;

            //A method to sort Applicants by score. The one with the least comes first.
        }

        public List<Applicant> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Id:
                    return GetAllApplicants().Where(a => a.Id.ToString() == value).ToList();
            }

            //when there is an error, program reaches this part
            return null;

            //A method which searches an Applicant with inserted ID number
        }
    }
}

