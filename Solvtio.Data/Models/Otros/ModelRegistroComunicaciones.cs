using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelRegistroComunicaciones
    {
        public List<Tuple<string, string>> LstFilesPendingProcess { get; set; }

        public List<string> LstFilesProcessed { get; set; } = new List<string>();
        public List<RegistroComunicacion> LstRegistroComunicacion { get; set; } = new List<RegistroComunicacion>();
        public List<string> LstUser { get; set; }
        public List<ModelRegistroComunicacionInfo> LstModelRegistroComunicacionInfo { get; set; } = new List<ModelRegistroComunicacionInfo>();

        public ModelFilterBase Filter { get; set; } = new ModelFilterBase();
    }

    public class ModelRegistroComunicacionInfo
    {
        public ModelRegistroComunicacionInfo() {}
        public ModelRegistroComunicacionInfo(string user, int noMes)
        {
            User = user;
            NoMes = noMes;
        }

        public string User { get; set; }
        public int NoMes { get; set; }
        public int TotalCall { get; set; }
    }
}
