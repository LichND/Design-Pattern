using BaseResponse;
using ResponseHelper;
using System;
using System.Collections.Generic;

namespace Adapter {
    public class AdvancedResponseAdapter : Response {
        protected ResponseHelperService helper;
        protected Dictionary<string, string> parsedCookie;

        public AdvancedResponseAdapter(Object body): base(body) {
            this.helper = new ResponseHelperService();
        }

        public override void SendFile(string file)
        {
            this.helper.EncryptFile(file);
            base.SendFile(file);
        }

        public override void SetCookie(string cookie) {
            base.SetCookie(cookie);
            this.parsedCookie = this.helper.ParseCookie(this.cookie);
            Console.WriteLine("Parsed cookie: ");   
            foreach (var pair in this.parsedCookie)
            {
                System.Console.WriteLine($"{pair.Key}: {pair.Value}");   
            }
        }
    }
}