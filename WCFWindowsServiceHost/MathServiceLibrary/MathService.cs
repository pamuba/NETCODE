﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MathService : IMathService
    {
        public int Adds(MyNumbers obj)
        {
            return (obj.Number1 + obj.Number2);
        }

        public int Subtracts(MyNumbers obj)
        {
            return (obj.Number1 - obj.Number2);

        }

    }
}
