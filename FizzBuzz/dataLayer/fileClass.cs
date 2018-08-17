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
    public class fileClass 
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);   

        public static void Log(string logMessage, TextWriter w)
        {
            try
            {

                log.Info("Beginning of the log function");

                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  ");
                w.WriteLine("  {0}", logMessage);
                w.WriteLine("-------------------------------");

                log.Info("End of the log function");

            }
            catch (Exception ex)
            {

                log.Error(ex.ToString());

            }
        }


        public int readFileCustomConfig()
        {
            try
            {

                int numberParsed = 0;
                string ruteRelativeToCustomFile = HttpRuntime.AppDomainAppPath;
                string ruteCustomFile = ruteRelativeToCustomFile + @"\customConfigFor.txt";
                string configtxt = "";
                using (StreamReader sr = File.OpenText(ruteCustomFile))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        configtxt = configtxt + s;
                    }

                    string[] parts = configtxt.Split(':');

                    if (Int32.TryParse(parts[1], out numberParsed))
                    {
                        log.Warn("Value cannot be parse to integer.");
                        numberParsed = int.Parse(parts[1]);
                        return numberParsed;

                    }
                    else if (parts[1] == "")
                    {
                        log.Error("Value in customConfigFor.txt is empty, the loop config it is now the client number +100.");
                        return 100;
                    }
                    else
                    {
                        log.Error("Value in customConfigFor.txt cannot be parsed to integer, the loop config it is now the client number +100.");
                        return 100;
                    }
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                return 100;
            }
        }

        public void createFile(string listNumbersToFile)
        {

            log.Info("Beginning of the createFile function");

            string fileBase = "\nLog Entry :\n " + DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString() + "\r\n  " + "\r\n  " + listNumbersToFile + "\r\n-------------------------------";
            string ruteRelative = HttpRuntime.AppDomainAppPath;
            string rute = ruteRelative + @"\Register.txt";


            try
            {

                // create file if not exists
                if (!File.Exists(rute))
                {

                    using (FileStream fs = File.Create(rute))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(fileBase);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                }
                else
                {

                    using (StreamWriter w = File.AppendText(rute))
                    {
                        Log(listNumbersToFile, w);

                    }

                }

                log.Info("File created");
                log.Info("End of the createFile function");

            }

            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }


        }

    }
}