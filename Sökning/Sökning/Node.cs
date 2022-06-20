﻿namespace Sökning;

internal class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; } = null;
    public Node<T>? Prev { get; set; } = null;

    public Node(T data)
    {
        Data = data;
    }
}
