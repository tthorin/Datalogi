namespace Datalogi_Inlamning;

using Datalogi_Inlamning.Interfaces;

public class BinarySearchTree<T> : IBstG<T>, IBstVg<T> where T : IComparable<T>
{
    private Node<T>? Root = null;
    private int _count = 0;

    public void Balance()
    {
        throw new NotImplementedException();
    }

    internal int GetBalance() => Root.GetBalance();

    public int Count() => _count;

    public bool Exists(T value)
    {
        throw new NotImplementedException();
    }

    public void Insert(T value)
    {
        var newNode = new Node<T>(value);
        if (Root is null)
        {
            Root = newNode;
            _count++;
            return;
        }
        var currentNode = Root;
        while (true)
        {
            if (newNode.Data.CompareTo(currentNode!.Data) == 0)
            {
                InsertSame(currentNode, newNode);
                return;
            }
            else if (newNode.Data.CompareTo(currentNode.Data) < 0)
            {
                if(currentNode.LeftChild == null)
                {
                    currentNode.LeftChild = newNode;
                    _count++;
                    return;
                }
                currentNode = currentNode.LeftChild;
            }
            else
            {
                if (currentNode.RightChild == null)
                {
                    currentNode.RightChild = newNode;
                    _count++;
                    return;
                }
                currentNode = currentNode.RightChild;
            }
        }
    }

    private void InsertSame(Node<T> currentNode,Node<T> nodeToInsert)
    {
        if (currentNode.LeftChild is null) currentNode.LeftChild = nodeToInsert;
        else if (currentNode.RightChild is null) currentNode.RightChild = nodeToInsert;
        else
        {
            var balance = currentNode.GetBalance();
            if (balance > 0) InsertSame(currentNode.LeftChild, nodeToInsert);
            else InsertSame(currentNode.RightChild, nodeToInsert);
        }
    }

    public void Remove(T value)
    {
        throw new NotImplementedException();
    }
}
