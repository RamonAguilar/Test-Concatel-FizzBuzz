using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]

public partial class _Default : System.Web.UI.Page
{

     private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            int number;
            string TotalDays;
            //creating the object of WCF service client   
            ServiceReference.FizzBuzzClient age = new ServiceReference.FizzBuzzClient();

            if (Int32.TryParse(TextBox1.Text, out number))
            {
                //assigning the input values to the variables   
                number = int.Parse(TextBox1.Text);

                //assigning the output value from service Response   
                TotalDays = age.GetListNumber(number);

                //assigning the output value to the lable to show user   
                Label1.Text = TotalDays;
                Label3.Text = "";
                log.Info("Value sent correctly.");
                log.Debug("Number = "+number);
                age.Close();

            }
            else if (TextBox1.Text == "")
            {
                Label1.Text = "";
                log.Warn("Warning: value has not been introduced");
                Label3.Text = "Warning: value has not been introduced.<br/>   Please introduce an integer.";

            }
            else
            {
                Label1.Text = "";
                log.Error("Error: value has not been introduced");
                Label3.Text = "Error: value is not an integer";

            }
        }catch(Exception ex){

            log.Error(ex.ToString());
            Label1.Text = "";
            Label3.Text = ex.ToString();
        
        }
    }
}
