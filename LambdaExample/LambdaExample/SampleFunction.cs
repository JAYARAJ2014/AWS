using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

/// <summary>
/// Lambda is nothing but Function As Service. Similar to Azure functions. 
/// </summary>
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace LambdaExample
{
    //AssmblyName::Namespace.ClassName::HandlerFunctionName
    //LambdaExample::LambdaExample.SampleFunction::FunctionHandler
    public class SampleFunction
    {

        public Stream FunctionHandler(string message, ILambdaContext context)
        {
            Console.WriteLine("Inside Function Handler");
            // convert string to stream
            string contents = "Hello World from Lambda by Jayaraj";
            byte[] byteArray = Encoding.UTF8.GetBytes(contents);
            //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
            MemoryStream stream = new MemoryStream(byteArray);
            return stream;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Lambda Function Locally");

            var stream = new SampleFunction().FunctionHandler("hi there", null);

            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();

            Console.WriteLine(text);
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
