

using System;
using System.Collections.Generic;

namespace BaseStrategy {
    
    public class AuthResult {
        public bool IsValid { get; protected set; }
        public String Error { get; protected set; }
        public Object result;

        public AuthResult(bool isValid, String error = null, Object result = null) {
            this.IsValid = isValid;
            this.Error = error;
            this.result = result;
        }

        public T GetResult<T>() {
            return (T)this.result;
        }

        public static AuthResult Create(bool isValid, String error = null, Object result = null) {
            return new AuthResult(isValid, error, result);
        }
        public static AuthResult Create<T>(bool isValid, String error = null, T result = default(T)) {
            return new AuthResult(isValid, error, result);
        }
    }

    public interface IAuthInfo {
        Object getInfo();
    }

    public interface AuthStrategy {
        AuthResult auth(IAuthInfo authInfo);
    }
}