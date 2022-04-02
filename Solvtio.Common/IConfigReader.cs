using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solvtio.Common
{
    public interface IConfigReader
    {
        string GetKeyToString(string clave);
        int GetKeyToInteger(string clave);
        bool GetKeyToBoolean(string clave);
    }

   
}
