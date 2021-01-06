using System;

namespace BaseResponse {
    public class Response : IResponse
    {
        protected string cookie;
        protected Object body;
        public Response(Object body) {
            this.cookie = "";
            this.body = body;
        }

        public virtual void Send(string contentType)
        {
            if (contentType.Equals("text/plain")) {
                Console.WriteLine("Send the response as text");
                return;
            }
            Console.WriteLine("The content type is not supported: " + contentType);
        }

        public virtual void SendFile(string file) {
            Console.WriteLine("Sending " + file);
        }

        public virtual void SetCookie(string cookie) {
            this.cookie = cookie;
        }
    }
}