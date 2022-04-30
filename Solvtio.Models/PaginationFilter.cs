namespace Solvtio.Models
{
    public class PaginationFilter
    {
        public PaginationFilter()
        {
            Pagination = new PaginationBase();
            Filter = new FilterBase();
        }
        
        public PaginationBase Pagination { get; set; } = new PaginationBase();
        public FilterBase Filter { get; set; } = new FilterBase();
    }

    public class PaginationBase
    {
        public int PageLimit { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
        
        public int TotalElements { get; set; } = 0;
        public int TotalPages => PageLimit == 0 ? 0 : (TotalElements / PageLimit);

        public int Rows2Skip => (PageNumber-1)*PageLimit;
    }

    public class FilterBase
    {
        public string? Code1 { get; set; }
        public string? Code2 { get; set; }
        public string? Code3 { get; set; }

        public int? IdTipo1 { get; set; }
        public int? IdTipo2 { get; set; }
        public int? IdTipo3 { get; set; }
    }
}