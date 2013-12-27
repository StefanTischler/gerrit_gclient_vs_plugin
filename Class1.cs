using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    public class Class1
    {
        static Class1 _instance;

        private Class1()
        {
            Class1._instance = this;
        }
    }
}
