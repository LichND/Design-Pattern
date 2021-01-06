


using System;
using BaseStrategy;

namespace Strategy {
    public class Route {
        protected AuthStrategy strategy;

        public Route() {}

        public void SetStrategy(AuthStrategy strategy) {
            this.strategy = strategy;
        }

        public bool Authenticate(IAuthInfo info) {
            if (this.strategy == null) {
                return false;
            }
            var authResult = this.strategy.auth(info);
            if (authResult.IsValid == true) {
                Console.WriteLine("User is authenticated");
                return true;
            }
            Console.WriteLine(authResult.Error);
            return false;
        }
    }
}