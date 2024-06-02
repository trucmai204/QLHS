using Database_Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Login
    {
        public AppDbContext Context { get;set;} = new AppDbContext();
        
    }
}
