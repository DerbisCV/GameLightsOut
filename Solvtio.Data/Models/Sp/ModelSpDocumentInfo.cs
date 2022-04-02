using Solvtio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvtio.Models
{
    public class ModelSpDocumentInfo
    {
        #region Constructors

        public ModelSpDocumentInfo()
        {
            LstSubfolder = new List<ModelSpDocumentInfoSubfolder>();
        }
        //public ModelSpDocumentInfo(string email)
        //{
        //    Email = email;
        //}
        //public ModelSpDocumentInfo(string menuOption, string email)
        //{
        //    MenuOption = menuOption;
        //    Email = email;
        //}

        #endregion

        #region Properties

        public List<ModelSpDocumentInfoSubfolder> LstSubfolder { get; set; }

        internal void Add(string subfolderName, List<Tuple<string, string>> lstAutos, string sharePointUrlBase)
        {
            if (LstSubfolder == null) LstSubfolder = new List<ModelSpDocumentInfoSubfolder>();

            var infoSubfolder = new ModelSpDocumentInfoSubfolder(subfolderName, lstAutos, sharePointUrlBase);
            LstSubfolder.Add(infoSubfolder);
        }

        #endregion
    }

    public class ModelSpDocumentInfoSubfolder
    {
        public ModelSpDocumentInfoSubfolder()
        {
            LstFiles = new List<ModelSpDocumentInfoRow>();
        }
        public ModelSpDocumentInfoSubfolder(string subfolderName, List<Tuple<string, string>> lstFiles, string sharePointUrlBase)
        {
            LstFiles = new List<ModelSpDocumentInfoRow>();
            SubfolderName = subfolderName;
            if (lstFiles.IsEmpty()) return;

            foreach (var item in lstFiles)
                LstFiles.Add(new ModelSpDocumentInfoRow(item, sharePointUrlBase));
        }

        #region Properties

        public string SubfolderName { get; set; }
        public List<ModelSpDocumentInfoRow> LstFiles { get; set; }

        #endregion
    }


    public class ModelSpDocumentInfoRow
    {
        #region Constructors

        public ModelSpDocumentInfoRow() { }
        public ModelSpDocumentInfoRow(Tuple<string, string> item, string sharePointUrlBase)
        {
            FileName = item.Item1;
            UrlFullPath = $"{sharePointUrlBase}{item.Item2}";
        }

        #endregion

        #region Properties

        public string UrlFullPath { get; set; }
        public string FileName { get; set; }

        #endregion
    }

}
