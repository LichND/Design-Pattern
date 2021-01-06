using System;
using Adapter;
using BaseResponse;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            IResponse responseOne = new ResponseFormatAdapter("Body of response 1");
            Console.WriteLine("======== RESPONSE 1 ===========");
            responseOne.Send("application/octet-stream");

            Console.WriteLine();
            
            Console.WriteLine("======== RESPONSE 2 ===========");
            Response responseTwo = new AdvancedResponseAdapter("Body of response 2");
            Console.WriteLine("Send file ======");
            responseTwo.SendFile("File A");
            Console.WriteLine("Set cookie ======");
            responseTwo.SetCookie("auth=true;sessionid=abc");
        }
    }
}
