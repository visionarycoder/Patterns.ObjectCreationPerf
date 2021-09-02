using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLibrary
{

    public interface ISampleRequest : IServiceMessageRequest
    {
        string Name { get; set; }
    }

    public class SampleRequest : ServiceMessageRequest, ISampleRequest
    {

        private static int counter = 0;
        public string Name { get; set; } = $"Sample {counter++}";
        
    }
}
