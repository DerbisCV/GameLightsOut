using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Solvtio.Common
{
    public class ConfigReader //: IConfigReader
    {
        //private AppSettingsReader Reader;

        public ConfigReader() 
        {
            //*Reader = new AppSettingsReader(*/);
        }

        //public string GetKeyToString(string clave) 
        //{
        //    string result = this.Reader.GetValue(clave, typeof(string)).ToString();

        //    return result;   
        //}

        //public int GetKeyToInteger(string clave)
        //{
        //    int result = -1;
        //    Int32.TryParse(GetKeyToString(clave), out result);

        //    return result;
        //}

        //public bool GetKeyToBoolean(string clave)
        //{
        //    bool result = false;
        //    Boolean.TryParse(GetKeyToString(clave), out result);

        //    return result;
        //}

    }
}
