using System;
using System.Collections.Generic;

namespace ResponseHelper {
    public class ResponseHelperService {
        public ResponseHelperService() {
        }

        public void EncryptFile(string file) {
            Console.WriteLine(file + " is encrypted");
        }

        public Dictionary<string, string> ParseCookie(string cookie) {
            Console.WriteLine("Cooke is parsed");
            string[] keyValueArrs = cookie.Split(";", StringSplitOptions.RemoveEmptyEntries);
            var parsedCookie = new Dictionary<string, string>();
            foreach (var keyValue in keyValueArrs)
            {  
                var parts = keyValue.Split("=");
                parsedCookie.Add(parts[0], parts[1]);
            }
            return parsedCookie;
        }
    }

}