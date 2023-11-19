namespace RecipesApp.Helpers
{
    public class PaginationParams
    {
        private const int _maxPageSize = 50;

        public int? PageNumber { get; set; }

        private int? _pageSize;

        public int? PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > _maxPageSize) ? _maxPageSize : value;
        }
    }
}
