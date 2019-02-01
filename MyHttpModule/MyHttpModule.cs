using System;
using System.Diagnostics;
using System.Web;

namespace MyHttpModule
{
    //HttpModule Docs
    //https://docs.microsoft.com/en-us/dotnet/api/system.web.ihttpmodule?view=netframework-4.7.2

    public class MyHttpModule : IHttpModule // HttpModuleBase
    {
        public void Init(HttpApplication context)
        {
            //Listing of all events
            //https://docs.microsoft.com/en-us/dotnet/api/system.web.httpapplication?view=netframework-4.7.2

            context.AuthenticateRequest += new EventHandler(AuthenticateRequestEventHandler);
        }

        public void AuthenticateRequestEventHandler(object o, EventArgs ea)
        {
            SetUserPrincipleFromHeaders(o, ea);
        }

        private void SetUserPrincipleFromHeaders(object o, EventArgs ea)
        {
            String username = HttpContext.Current.Request.Headers.Get("NTLM-User");
            String domain = HttpContext.Current.Request.Headers.Get("NTLM-Domain");

            username = String.IsNullOrEmpty(username) ? "Unknown" : username;
            domain = String.IsNullOrEmpty(domain) ? "Unknown" : domain;

            String principleName = domain + '\\' + username;

            Log("###" + this.GetType().ToString() + ": " + "The principal name is: " + principleName);

            HttpContext.Current.User = new MyUser(new System.Security.Principal.GenericIdentity(principleName), new String[0]);
        }

        private void Log(String msg)
        {
            Debug.WriteLine(msg);
            Console.WriteLine(msg);
        }

        public void Dispose()
        {
            //do nothing
        }
    }
}