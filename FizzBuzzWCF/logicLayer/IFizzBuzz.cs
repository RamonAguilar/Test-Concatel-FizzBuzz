﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace FizzBuzz
{
    
    [ServiceContract]
    public interface IFizzBuzz
    {
       
        [OperationContract]
        string GetListNumber(int numberSend);

    }
}
