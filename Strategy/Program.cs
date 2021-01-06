using System;
using BaseStrategy;
using BasicAuth;
using GoogleAuth;
using TokenAuth;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var route = new Route();

            Console.WriteLine("============== Google Authentication"); 
            route.SetStrategy(new GoogleAuthStrategy());
            IAuthInfo googleAuthInfo = new GoogleAuthInfo("12114141", new string[]{
                "google.drive.all"
            });
            route.Authenticate(googleAuthInfo);

            Console.WriteLine("============== Basic Authentication");
            route.SetStrategy(new BasicStrategy());
            IAuthInfo basicAuth = new BasicAuthInfo("usera", "passworda"); 
            route.Authenticate(basicAuth);

            Console.WriteLine("============== Token Authentication");
            route.SetStrategy(new TokenStrategy());
            IAuthInfo tokenAuth = new TokenAuthInfo("Bearer afaf2451cceff"); 
            route.Authenticate(tokenAuth);
        }
    }
}
