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

            int numberFromUser;
            string listOfNumbers;
            //creating the object of WCF service client   
            ServiceReference.FizzBuzzClient service = new ServiceReference.FizzBuzzClient();

            if (Int32.TryParse(TextBox1.Text, out numberFromUser))
            {
                //assigning the input values to the variables   
                numberFromUser = int.Parse(TextBox1.Text);

                //assigning the output value from service Response   
                listOfNumbers = service.GetListNumber(numberFromUser);

                //assigning the output value to the lable to show user   
                LabelSucces.Text = listOfNumbers;
                LabelError.Text = "";
                log.Info("Value sent correctly.");
                log.Debug("Number = " + numberFromUser);
                log.Debug("List of numbers = " + listOfNumbers);
                service.Close();

            }
            else if (TextBox1.Text == "")
            {
                LabelSucces.Text = "";
                log.Warn("Warning: value has not been introduced. ");
                LabelError.Text = "Warning: value has not been introduced.<br/>Please enter a number that is not decimal.";

            }
            else
            {
                LabelSucces.Text = "";
                log.Error("Error: the value is not a integer number");
                LabelError.Text = "Error: the value is not a integer number.<br/>Please enter a number that is not decimal.";

            }
        }catch(Exception ex){

            log.Error(ex.ToString());
            LabelSucces.Text = "";
            LabelError.Text = "Error the aplication can not work.";
        
        }
    }
}
