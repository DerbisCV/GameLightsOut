using System.Collections.Generic;

namespace Solvtio.Models
{
    public class ModelDashboardSlaChild
    {
        #region Constructor

        public ModelDashboardSlaChild()
        {
            CreateBase();
        }
        public ModelDashboardSlaChild(SlaType slaType)
        {
            CreateBase();
            SlaType = slaType;
        }

        private void CreateBase()
        {
            LstModelDashboardSlaChildDetail = new List<ModelDashboardSlaChildDetail>();
            CssClassBase = "green-bg";
        }

        #endregion

        #region Properties

        public SlaType SlaType { get; set; }
        public List<ModelDashboardSlaChildDetail> LstModelDashboardSlaChildDetail { get; set; }
        public string CssClassBase { get; set; }

        #endregion
    }
}
