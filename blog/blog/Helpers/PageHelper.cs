using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.Helpers
{
    public static class PageHelper
    {
        public static IEnumerable<int> PageNumbers(int pageNumber, int pageCount)
        {
            List<int> pages = new List<int>();
            if (pageCount <= 5)
            {
                for (int i = 1; i <= pageCount; i++)
                {
                    pages.Add(i);
                }
            }
            else
            {
                int midPoint = pageNumber < 3 ? 3
                : pageNumber > pageCount - 2 ? pageCount - 2
                : pageNumber;

                for (int i = midPoint - 2; i <= midPoint + 2; i++)
                {
                    pages.Add(i);
                }
            }
            return pages;
        }
    }
}
