//In this task, you're given a class AnalogToDigital. It has some methods. You have to convert all of the methods to lambda methods without changing the functionality. You shouldn’t make any unnecessary changes as well. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AnalogToDigital
    {
        private string? _ip;
        private string? _fullAddress;
        public Action<string> MakeConnection => caller => 
        
        _fullAddress = GetFullAddress(caller);
        

        public Action Close => () => _ip = null;

        public Func<string, string?> GetFullAddress => caller  =>
        
        _ip + caller;
        
    }
}
