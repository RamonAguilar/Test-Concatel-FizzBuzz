using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Reflection;
using System.Web;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace FizzBuzz
{

    public class FizzBuzz : IFizzBuzz
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        fileClass fileMetodes = new fileClass();

        public int readFileCustomConfig()
        {
            if (fileMetodes != null)
            {

                int numberToFor =fileMetodes.readFileCustomConfig();
                log.Debug("value of number for loops: " + numberToFor);

                return numberToFor; 

            }else {

                    return 100; 
            }
        } 

        public void createFile(string listNumbersForFile)
        {
            if (fileMetodes != null)
            {

                fileMetodes.createFile(listNumbersForFile);

            }
          
        }

        public string createListFizzBuzz(int number) {

            try
            {
                log.Info("Beginning of the createListFizzBuzz function");

                string listNumberSend = "";

                Boolean numberNoFizzBuzz = true;

                int configNumberFor = fileMetodes.readFileCustomConfig();

                for (int i = number; i <= number + configNumberFor; i++)
                {

                    if (i % 3 == 0)
                    {

                        listNumberSend = listNumberSend + "Fizz";
                        numberNoFizzBuzz = false;

                    }
                    if (i % 5 == 0)
                    {

                        listNumberSend = listNumberSend + "Buzz";
                        numberNoFizzBuzz = false;

                    } if (numberNoFizzBuzz == true)
                    {

                        listNumberSend = listNumberSend + i;

                    }

                    numberNoFizzBuzz = true;
                    if (i < number + 100)
                    {
                        listNumberSend = listNumberSend + ", ";
                    }
                }

                log.Info("End of the createListFizzBuzz function");

                log.Debug(listNumberSend);

                return listNumberSend;

            }catch(Exception e){

                log.Error(e.ToString());
                return e.ToString();
            
            }
        }

        public string GetListNumber(int numberGet)
        {

            try
            {
                log.Info("Beginning of the GetListNumber function");

                string listNumbers = createListFizzBuzz(numberGet);

                fileMetodes.createFile(listNumbers);

                log.Info("End of the GetListNumber function");

                return listNumbers;
              
               
            }
            catch (Exception e) {

                log.Error(e.ToString());
                return e.ToString();

            }
        }
    }
}
