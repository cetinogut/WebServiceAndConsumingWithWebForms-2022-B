using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApplicationForConsumingCalcWebService
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            ServiceReferenceCogut.WebServiceCalc_2022_BSoapClient client = new ServiceReferenceCogut.WebServiceCalc_2022_BSoapClient();
            string result = client.Calculator(
                    Convert.ToInt32(txtFirstValue.Text),
                    Convert.ToInt32(txtSecondValue.Text),
                    txtOperation.Text);

            if (result != "")
            {
                lblResult.Text = "Result:  <b style='color:Green'>" + result.ToString() + "</b>";
            }

        }
    }
}