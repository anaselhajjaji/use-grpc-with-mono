using System;
using Helloworld;

namespace GreeterClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            GreeterClient.GrpcClient.Start("Anas");
        }
    }
}
