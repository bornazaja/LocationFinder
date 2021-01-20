using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationFinderLibrary.BLL.Pagination
{
    public class PagedList<T>
    {
        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }
        public IEnumerable<T> Subset { get; private set; }

        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize)
        {
            Subset = new List<T>();
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = source.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            ((List<T>)Subset).AddRange(source.Skip(PageIndex * PageSize).Take(PageSize));
        }
    }
}
