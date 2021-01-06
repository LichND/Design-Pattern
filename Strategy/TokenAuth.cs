

using System;
using System.Collections.Generic;
using BaseStrategy;

namespace TokenAuth {


    public class TokenAuthInfo : IAuthInfo {
        protected String token;

        public String Token => this.token;

        public TokenAuthInfo(String token) {
            this.token = token;
        }

        public object getInfo()
        {
            return new Tuple<string>(this.token);
        }
    }

    public class TokenStrategy : AuthStrategy
    {
        protected readonly string VALID_TOKEN = "afaf2451cceff";
        protected String type;
        protected readonly Dictionary<String, String> DECODE_RESULT = new Dictionary<String, String>() {
            { "UserID", "123" },
            { "Fullname", "User A" }
        };

        public TokenStrategy(String type = "Bearer") {
            this.type = type;
        }
        public AuthResult auth(IAuthInfo authInfo)
        {
            var tokenInfo = authInfo as TokenAuthInfo;
            if (tokenInfo == null) {
                return AuthResult.Create(false, "Invalid token info");
            }
            var parts = tokenInfo.Token.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2) {
                return AuthResult.Create(false, "Invalid token format");
            }
            if (!parts[0].Equals(this.type)) {
                return AuthResult.Create(false, "Invalid token type");
            }
            if (!parts[1].Equals(this.VALID_TOKEN)) {
                return AuthResult.Create(false, "Invalid token value");
            }
            return AuthResult.Create(true, null, this.DECODE_RESULT);
        }
    }
}