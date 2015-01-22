using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountButton_Click(object sender, EventArgs e)
        {
            var input = InputTextBox.Text;
            ResultLabel.Text = "Antal versaler: " + Model.TextAnalyzer.GetNumberOfCapitals(input).ToString();

            if(InputTextBox.Enabled == true)
            {
                InputTextBox.Enabled = false;
                CountButton.Text = "Ny uträckning";
            }
            else
            {
                InputTextBox.Text = "";
                ResultLabel.Text = "";
                InputTextBox.Enabled = true;
                CountButton.Text = "Räkna antalet versaler";
            }
        }
    }
}