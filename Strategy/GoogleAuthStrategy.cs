

using System;
using System.Collections.Generic;
using BaseStrategy;

namespace GoogleAuth {


    public class GoogleAuthInfo : IAuthInfo {
        protected String userId;
        protected String[] scopes;

        public String UserId => this.userId;
        public String[] Scopes => this.scopes;

        public GoogleAuthInfo(String userId, String[] scopes) {
            this.userId = userId;
            this.scopes = scopes;
        }

        public object getInfo()
        {
            return new Tuple<String, String[]>(this.UserId, this.Scopes);
        }
    }

    public class GoogleAuthStrategy : AuthStrategy
    {
        protected readonly String VALID_USER_ID = "12114141";
        protected readonly HashSet<string> VALID_SCOPES = new HashSet<string>(new string[] {
            "google.drive.all",
            "google.userinfo.all"
        });
        protected readonly String REFRESH_TOKEN = "aff13afbcdd";
        public AuthResult auth(IAuthInfo authInfo)
        {
            var ggInfo = authInfo as GoogleAuthInfo;
            if (ggInfo == null) {
                return AuthResult.Create(false, "Invalid google auth info");
            }
            if (!ggInfo.UserId.Equals(this.VALID_USER_ID)) {
                return AuthResult.Create(false, "Invalid user id");
            }
            if (ggInfo.Scopes.Length == 0 || !this.VALID_SCOPES.IsSupersetOf(ggInfo.Scopes)) {
                return AuthResult.Create(false, "Invalid requested scopes");
            }
            return AuthResult.Create(true, null, "aff13afbcdd");
        }
    }
}