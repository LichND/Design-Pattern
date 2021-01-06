using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseHelper {
    public class ResponseSender {

        protected Object body;
        public ResponseSender(Object body) {
            this.body = body;
        }

        public void SendAsJSON() {
            var dictBody = this.body as Dictionary<string, Object>;
            if (dictBody == null) {
                Console.WriteLine("Cannot parse body to JSON");
                return;
            }
            Console.WriteLine("Send response as JSON:");
            StringBuilder builder = new StringBuilder();
            builder.Append("{");
            foreach (var pair in dictBody)
            {
                builder.Append($"\"{pair.Key}\": \"{pair.Value}\",");
            }
            builder.Remove(builder.Length - 1, 1);
            builder.Append("}");
            Console.WriteLine(builder.ToString());
        }

        public void SendAsBinary() {
            System.Console.WriteLine("Sending response as BINARY: ");
            if (this.body == null) {
                Console.WriteLine("NULL");
                return;
            }
            StringBuilder builder = new StringBuilder();
            foreach (var c in this.body.ToString().ToCharArray())
            {
                builder.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            Console.WriteLine(builder.ToString());
        }
    }
}