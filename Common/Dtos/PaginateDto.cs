namespace Common.Dtos;

public class PaginateDto<T>
{
    public PaginateDto(int from, int index, int size, int count, int pages, IList<T> items, bool hasPrevious, bool hasNext)
    {
        From = from;
        Index = index;
        Size = size;
        Count = count;
        Pages = pages;
        Items = items;
        HasPrevious = hasPrevious;
        HasNext = hasNext;
    }

    int From { get; }
    int Index { get; }
    int Size { get; }
    int Count { get; }
    int Pages { get; }
    IList<T> Items { get; }
    bool HasPrevious { get; }
    bool HasNext { get; }
}