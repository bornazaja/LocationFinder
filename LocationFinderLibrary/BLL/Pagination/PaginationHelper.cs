using System.Collections.Generic;

namespace LocationFinderLibrary.BLL.Pagination
{
    public class PaginationHelper
    {
        public static IEnumerable<int> GetItemsPerPageList()
        {
            return new List<int>
            {
                10, 25, 50, 100
            };
        }
    }
}
