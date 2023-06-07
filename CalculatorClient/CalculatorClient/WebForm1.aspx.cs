using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            float numerator = ((float)Convert.ToDouble(txtNumerator.Text));
            float denominator = ((float)Convert.ToDouble(txtDenominator.Text));

            CalculatorServiceReference.CalculatorServiceClient client = new CalculatorServiceReference.CalculatorServiceClient();

            lblResult.Text = client.Divide(numerator, denominator).ToString();
        }
    }
}