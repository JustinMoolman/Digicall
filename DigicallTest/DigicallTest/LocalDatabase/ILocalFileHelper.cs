﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigicallTest.LocalDatabase
{
    public interface ILocalFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
