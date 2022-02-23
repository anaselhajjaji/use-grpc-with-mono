using System;
using Helloworld;

namespace GreeterServer
{
    class Program
    {
        public static void Main(string[] args)
        {
            GreeterServer.GrpcServer.Start();
        }
    }
}
