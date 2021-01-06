using System;
using System.Collections.Generic;
using BaseStrategy;

namespace BasicAuth {


    public class BasicAuthInfo : IAuthInfo {
        protected String username;
        protected String password;

        public String Username => this.username;
        public String Password => this.password;
        public BasicAuthInfo(String username, String password) {
            this.username = username;
            this.password = password;
        }
        public Object getInfo()
        {
            return new Tuple<string, string>(this.username, this.password);
        }
    }

    public class BasicStrategy : AuthStrategy
    {
        private String VALID_USERNAME = "usera";
        private String VALID_PASSWORD = "passworda";
        public AuthResult auth(IAuthInfo authInfo)
        {
            var basicInfo = authInfo as BasicAuthInfo;
            if (basicInfo == null) {
                return AuthResult.Create(false, "Invalid authentication info");
            }
            if (basicInfo.Username.Equals(this.VALID_USERNAME) 
                && basicInfo.Password.Equals(this.VALID_PASSWORD)
            ) {
                return AuthResult.Create(true);
            }
            return AuthResult.Create(false, "Invalid username or password");
        }

    }
}