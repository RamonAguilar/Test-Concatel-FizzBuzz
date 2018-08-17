using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace FizzBuzz
{
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpInfoService" in both code and config file together.
    [ServiceContract]
    public interface IFizzBuzz
    {
       
        [OperationContract]
        string GetListNumber(int numberSend);

    }
}
