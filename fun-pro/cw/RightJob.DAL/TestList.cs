using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightJob.DAL
{
    public class TestList
    {
        public List<Test> GetAllTests()
        {
            return new TestManager().GetAll();

            //A method calling a GetAll() method of manager class
        }
    }
}
