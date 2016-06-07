using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace Gnusys
{
    /// <summary>
    /// Summary description for AndroidWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class AndroidWebService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(UseHttpGet=true)]
        public string AuthenticateLogin(string cpr, string password)
        {
            if(cpr == "111" && password=="admin")
            {
                return "ok";
            }
            else
            {
                return "fejl";
            }
            
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public bool AddReadings(int OxygenSaturation, int pulse)
        {
            return false;
        }
    }
}
