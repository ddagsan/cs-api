using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Pagination
{
    public class PaginatedObject<T> where T : class
    {
        public PagedList<T> List { get; set; }
        public PaginatedObject(PagedList<T> list)
        {
            List = list;

            PageIndex = list.PageIndex;
            PageSize = list.PageSize;
            TotalCount = list.TotalCount;
            TotalPages = list.TotalPages;
            HasPreviousPage = list.HasPreviousPage;
            HasNextPage = list.HasNextPage;
        }
        /// <summary>
        /// Page index
        /// </summary>
        public int PageIndex { get; }

        /// <summary>
        /// Page size
        /// </summary>
        public int PageSize { get; }

        /// <summary>
        /// Total count
        /// </summary>
        public int TotalCount { get; }

        /// <summary>
        /// Total pages
        /// </summary>
        public int TotalPages { get; }

        /// <summary>
        /// Has previous page
        /// </summary>
        public bool HasPreviousPage { get; }

        /// <summary>
        /// Has next age
        /// </summary>
        public bool HasNextPage { get; }
    }
}
