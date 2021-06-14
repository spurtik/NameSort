using NameSorter.Comparers;
using System.Collections.Generic;

namespace NameSorter.Sorters
{
    public interface ISorter<TModel>
    {
         INameComparer<TModel> Comparer 
         {
             get;
         }
        void Sort(List<TModel> targetArray);
    }
}