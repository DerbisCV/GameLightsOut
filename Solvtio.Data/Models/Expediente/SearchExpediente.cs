using System.Collections.Generic;

namespace Solvtio.Models
{
    public class SearchExpediente
    {
        #region Constructors
        
        public SearchExpediente() 
        {
            PaginationFilter = new PaginationFilter();
        }

        public SearchExpediente(PaginationFilter paginationFilter) : this()
        {
            PaginationFilter = paginationFilter;
        }

        #endregion

        #region Properties

        public PaginationFilter PaginationFilter { get; set; }
        public List<ModelExpediente> Results { get; set; }

        #endregion

        #region Properties ReadOnly

        public bool HasResults => Results != null && Results.Count > 0;
        
        //public int SubastasSenaladasTotal
        //{
        //    get
        //    {
        //        if (!_subastasSenaladasTotal.HasValue)
        //            _subastasSenaladasTotal = this.LstResumenMes.Sum(x => x.SubastasSenaladas);

        //        return _subastasSenaladasTotal.Value;
        //    }
        //}
        #endregion
    }
}
