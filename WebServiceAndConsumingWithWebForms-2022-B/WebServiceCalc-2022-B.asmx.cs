using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceAndConsumingWithWebForms_2022_B
{
    /// <summary>
    /// Summary description for WebServiceCalc_2022_B
    /// </summary>
    [WebService(Namespace = "http://dastugo.com/web_services/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCalc_2022_B : System.Web.Services.WebService
    {

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}

        [WebMethod]
        public string HelloWorld(string firstname, string lastname)
        {
            return string.Format("Hello {0} {1}", firstname, lastname);
        }

        [WebMethod(Description ="Calc app and parameters int firstvalue, int secondvalue, string operation")]

        public string Calculator(int firstvalue, int secondvalue, string operation)
        {
            double result = 0;

            switch(operation)
            {
                case "+": result = (double)firstvalue + (double)secondvalue;
                    break;

                case "-":
                    result = (double)firstvalue - (double)secondvalue;
                    break;

                case "x":
                    result = (double)firstvalue * (double)secondvalue;
                    break;

                case "*":
                    result = (double)firstvalue * (double)secondvalue;
                    break;


                case "/":
                    result = (double)firstvalue / (double)secondvalue;
                    break;
            }

            //return null;
            return result.ToString();
        }

    }
}
