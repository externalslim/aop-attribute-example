using System.Collections.Generic;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Concretes
{
    public class TransportService : ITransportService
    {
        private static List<Test> _testList;
        
        
        public TransportService()
        {
            _testList = new List<Test>()
                {
                    new Test()
                    {
                        Name = "cihan",
                        Surname = "agirbas"
                    }
                };
        }

        public List<Test> TestList {
            get
            {
                return _testList;
            }
            set
            {
                _testList = value;
            }
        }
    }
}
