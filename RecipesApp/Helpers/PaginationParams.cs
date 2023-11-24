namespace RecipesApp.Helpers
{
    public class PaginationParams
    {
        private const int _maxPageSize = 50;

        private const int _minPageSize = 1;

        private const int _minPageNumber = 1;

        public int _pageNumber { get; set; }

        public int PageNumber
        {
            get => _pageNumber;
            set => _pageNumber = (value < _minPageNumber) ? _minPageNumber : value;
        }

        private int _pageSize;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > _maxPageSize) ? _maxPageSize : (value < _minPageSize) ? _minPageSize : value;
        }

        public string? OrderBy { get; set; }
        public string? Filter { get; set; }
    }
}
