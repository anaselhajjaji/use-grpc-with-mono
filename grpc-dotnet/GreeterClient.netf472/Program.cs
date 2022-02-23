using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreeterClient.netf472
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreeterClient.GrpcClient.Start("Anas");
        }
    }
}
