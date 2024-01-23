namespace CityInfo.API.Services
{
    public class PaginationMetadata
    {
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public PaginationMetadata(int totalItemCoint, int pageSize, int currentPage)
        {
            TotalItemCount = totalItemCoint;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCoint / (double)pageSize);
        }
    }
}
