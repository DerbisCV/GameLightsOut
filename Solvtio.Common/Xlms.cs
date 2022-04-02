using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solvtio.Common
{
    public static class Xlms
    {

        public static int? GetValueOfInteger(this XElement xmlData, string elementsName)
        {
            var resultStr = xmlData.GetValueOf(elementsName);
            if (string.IsNullOrWhiteSpace(resultStr)) return null;

            int result = 0;
            if (int.TryParse(resultStr, out result)) return result;

            return null;
        }

        public static decimal? GetValueOfDecimal(this XElement xmlData, string elementsName)
        {
            var resultStr = xmlData.GetValueOf(elementsName);
            if (string.IsNullOrWhiteSpace(resultStr)) return null;

            decimal result = 0;
            if (decimal.TryParse(resultStr, out result)) return result;

            return null;
        }

        public static string GetValueOf(this XElement xmlData, string elementsName)
        {
            try
            {
                XElement itemCurrent = null;
                foreach (var namePartial in elementsName.Split('-'))
                {
                    if (itemCurrent == null)
                        itemCurrent = xmlData.Elements().Where(x => x.Name.LocalName.Equals(namePartial)).FirstOrDefault();
                    else
                        itemCurrent = itemCurrent.Elements().Where(x => x.Name.LocalName.Equals(namePartial)).FirstOrDefault();
                }

                return itemCurrent?.Value;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<XElement> GetElementsOf(this XElement xmlData, string elementsName)
        {
            try
            {
                XElement itemCurrent = null;
                foreach (var namePartial in elementsName.Split('-'))
                {
                    if (itemCurrent == null)
                        itemCurrent = xmlData.Elements().Where(x => x.Name.LocalName.Equals(namePartial)).FirstOrDefault();
                    else
                        itemCurrent = itemCurrent.Elements().Where(x => x.Name.LocalName.Equals(namePartial)).FirstOrDefault();
                }

                return itemCurrent.Elements().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}



