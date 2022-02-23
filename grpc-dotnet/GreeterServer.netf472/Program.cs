using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterServer.netf472
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreeterServer.GrpcServer.Start();
        }
    }
}
