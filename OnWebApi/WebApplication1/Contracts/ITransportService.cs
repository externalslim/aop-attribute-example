using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Contracts
{
    public interface ITransportService
    {
        public List<Test> TestList { get; set; }
    }
}
