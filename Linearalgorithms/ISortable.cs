namespace Algorithms.Sort
{
    public enum eOrderBy { Asc, Desc }

    public interface ISortable
    {
        int[] Sort(int[] numbers, eOrderBy orderBy);
    }
}