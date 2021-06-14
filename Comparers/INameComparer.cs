
namespace NameSorter.Comparers
{
    public interface INameComparer<TModel>
    {
         int Compare(TModel ObjectA, TModel ObjectB);
    }
}