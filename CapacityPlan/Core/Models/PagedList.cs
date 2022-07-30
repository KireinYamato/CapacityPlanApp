using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CapacityPlanApp.Core.Models
{
    public class PagedList<T> : List<T>
    {
        public int currentPage { get; private set; }
        public int totalPages { get; private set; }
        public int pageSize { get; private set; }
        public int totalCount { get; private set; }

        public bool hasPrevious => currentPage > 1;
        public bool hasNext => currentPage < totalPages;

        public PagedList(List<T> items, int count, int pageNumber, int _pageSize)
        {
            totalCount = count;
            pageSize = _pageSize;
            currentPage = pageNumber;
            totalPages = (int)Math.Ceiling(count / (double)_pageSize);

            AddRange(items);
        }

        public static PagedList<T> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }

        public static string ToJson(object value)
        {
            var results = value as PagedList<T>;

            var metadata = new
            {
                results.totalCount,
                results.pageSize,
                results.currentPage,
                results.totalPages,
                results.hasNext,
                results.hasPrevious
            };

            return JsonConvert.SerializeObject(metadata);
        }
    }
}
