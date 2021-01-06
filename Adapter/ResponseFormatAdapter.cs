using System;
using ResponseHelper;
using BaseResponse;

namespace Adapter {
    public class ResponseFormatAdapter : IResponse {
        private ResponseSender adaptee;
        protected Object body;

        public ResponseFormatAdapter(Object body) {
            this.body = body;
            this.adaptee = new ResponseSender(body);
        }

        public void Send(string contentType)
        {
            switch (contentType)
            {
                case "application/json": this.adaptee.SendAsJSON(); break;
                case "application/octet-stream": this.adaptee.SendAsBinary(); break;
                default:
                    this.Send(contentType);
                    break;
            }
        }
    }
}