using System;

namespace Solvtio.Common
{
    public class Model2Action
    {
        #region Constructors

        public Model2Action()
        {
            CreateBase();
        }
        public Model2Action(string text2Show, string url, string classI = "", string classA = "", string target = "_blank")
        {
            CreateBase();
            Text2Show = text2Show;
            Url = url;
            ClassI = classI;
            ClassA = classA;
            Target = target;
        }

        private void CreateBase()
        {
            Url = "#";
            Target = "_blank";
        }

        #endregion

        #region Properties

        public string Text2Show { get; set; }
        public string Url { get; set; }
		public string Target { get; set; }
		public string ClassA { get; set; }
		public string ClassI { get; set; }

        #endregion

        #region Properties ReadOnly

        private string ElemetI => string.IsNullOrWhiteSpace(ClassI) ? String.Empty : $"<i class='{ClassI}'></i> ";

        #endregion

        public override string ToString() 
        {
            return Text2Show == "divider" || Url == "divider" ? string.Empty :
                $"<a href='{Url}' target='{Target}' class='{ClassA}'>{ElemetI}{Text2Show}</a>";
        }

    }

}
