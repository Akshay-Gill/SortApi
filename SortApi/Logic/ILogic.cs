using SortApi.Models;
using System.Collections.Generic;

namespace SortApi.Business
{
    public interface ILogic
    {
        List<Rectangle> SortRectangle(List<Rectangle> rectangleList, string sortBy);

    }
}
