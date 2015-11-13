using CodeConventionsSample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeConventionsSample.Managers
{
    public class SampleManager : ISampleManager
    {
        private ISampleRepository repository;

        public SampleManager(ISampleRepository repo)
        {
            repository = repo;
        }

        public int DoSomeCalculations(List<string> lst)
        {
            var ret = 0;

            foreach (var item in lst)
            {
                if (item.Length % 2 == 0)
                {
                    ret++;
                }
            }

            return ret;
        }
    }
}
