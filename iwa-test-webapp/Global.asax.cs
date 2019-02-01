using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace iwa_test_webapp
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //void Application_OnPostAuthenticateRequest(object sender, EventArgs e)
        //{
        //    HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(
        //        new System.Security.Principal.GenericIdentity("John Doe"),
        //        new String[0]);
        //}


    }
}


/*
// Get a reference to the current User
IPrincipal objIPrincipal = HttpContext.Current.User;

// If we are dealing with an authenticated forms authentication request
if ((objIPrincipal.Identity.IsAuthenticated) && (objIPrincipal.Identity.AuthenticationType == "Forms"))
{
    CustomPrincipal objCustomPrincipal = new CustomPrincipal();
    objCustomPrincipal = objCustomPrincipal.GetCustomPrincipalObject(objIPrincipal.Identity.Name);
    HttpContext.Current.User = objCustomPrincipal;
    CustomIdentity ci = (CustomIdentity)objCustomPrincipal.Identity;
    HttpContext.Current.Cache["CountryID"] = FatchMasterInfo.GetCountryID(ci.CultureId);
    HttpContext.Current.Cache["WeatherLocationID"] = FatchMasterInfo.GetWeatherLocationId(ci.UserId);
    Thread.CurrentPrincipal = objCustomPrincipal;
}
*/
