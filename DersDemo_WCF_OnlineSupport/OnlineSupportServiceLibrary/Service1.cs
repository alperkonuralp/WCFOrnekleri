﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OnlineSupportServiceLibrary.Entities;

namespace OnlineSupportServiceLibrary
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public ChatData GetDataUsingDataContract()
        {
            return new ChatData();
        }
    }
}
