using System.Collections.Generic;
using UnityEngine;

public class Pool<T>
{

    public Stack<T> members = new Stack<T>();
    IFactory<T> factory;

    public Pool(IFactory<T> factory)
    {
        this.factory = factory;

    }

    public T Take()
    {
        if (members.Count != 0)
            return members.Pop();

        return Create();
    }

    private T Create()
    {
        return factory.Create();
    }

    public void Return(T member)
    {
        members.Push(member);
    }

}