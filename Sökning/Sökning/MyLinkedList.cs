// See https://aka.ms/new-console-template for more information

using Sökning;
using Sökning.Interfaces;

internal class MyLinkedList<T> : IIndexable<T>
{
    public Node<T>? Head { get; set; }
    public Node<T>? Tail { get; set; }
    public Node<T>? CurrentNode { get; set; }
    public int Count { get; set; }

    public void Push(T data)
    {
        var newNode = new Node<T>(data);

        newNode.Next = Head;
        if (Head is not null) Head.Prev = newNode;
        Head = newNode;

        if (Tail is null) Tail = newNode;
        else if (Tail.Prev is null) Tail.Prev = newNode;

        Tail.Next = Head;
        Head.Prev = Tail;

        if (CurrentNode is null) CurrentNode = newNode;
        Count++;
    }

    public Node<T> GetNodeAtIndex(int idx)
    {
        if (Count == 0) throw new Exception($"List contains no elements.");
        if (idx < 0 || idx >= Count)
        {
            throw new IndexOutOfRangeException($"Index must be a value between 0 and the number of items in the MyLinkedList. The index given was {idx} and the length of the myLinkeList was {Count}");
        }

        var distFromMiddle = idx - Count / 2;

        Node<T> result = Head!;
        if (distFromMiddle <= 0)
        {
            for (int i = 0; i < idx; i++)
            {
                result = result.Next!;
            }
        }
        else
        {
            result = Tail!;
            for (int i = Count - 1; i > idx; i--)
            {
                result = Tail.Prev!;
            }
         }
        return result!;
    }
    public T Get(int idx) => GetNodeAtIndex(idx).Data;

    public void RemoveAt(int idx)
    {
        var node = GetNodeAtIndex(idx);
        if(node.Prev == node)
        {
            Head = null;
            Tail = null;
            CurrentNode = null;
        }
        else
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            if (node == CurrentNode)
            {
                CurrentNode = node.Next;
            }
        }
        if (Count > 0) Count--;
    }
    public T Iterate()
    {
        var result = CurrentNode.Data;
        Next();
        return result;
    }

    public T Current() => CurrentNode.Data;
    public void Next() => CurrentNode = CurrentNode.Next;

    public void Reset() => CurrentNode = Head;
    public int Length() => Count;
    public T GetAt(int index) => Get(index);
    public void SetAt(int index, T value) => GetNodeAtIndex(index).Data = value;
    public int IndexOf(T item)
    {
        var node = Head;
        for (int i = 0; i < Count; i++)
        {
            if (node.Data.Equals(item)) return i;
            node = node.Next;
        }
        return -1;
    }
}