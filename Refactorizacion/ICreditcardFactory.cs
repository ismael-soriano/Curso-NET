﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactorizacion
{
    public interface ICreditcardFactory
    {
        ICreditCard GetCard(Type cardType, params object[] args);
    }
}
