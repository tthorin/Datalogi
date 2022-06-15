// See https://aka.ms/new-console-template for more information

using DatalogiOvn1;

internal class MyLinkedList<T>
{
    public Node<T>? Head{ get; set; }
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
        
        if(CurrentNode is null) CurrentNode = newNode;
        Count++;
    }
    
    public T Get(int idx)
    {
        //TODO: improve now that node has more props, note to self, check idx for closeness to current, head, tail
        var distFromMiddle = idx > Count / 2 ? idx - (Count / 2) : Count / 2 - idx;


        Node <T> output = Head;
        for (int i = 0; i < idx; i++)
        {
            output = output.Next;
        }
        return output.Data;
    }
    public T Iterate()
    {
        var result = CurrentNode.Data;
        Next();
        return result;
    }

    public T Current() => CurrentNode.Data;
    public void Next()
    {
        CurrentNode = CurrentNode.Next;
    }

    public void Reset()
    {
        CurrentNode = Head;
    }

}