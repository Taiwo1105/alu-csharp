using System;

public class Queue<T>
{
    // Method that returns the type of the generic parameter T
    public Type CheckType()
    {
        return typeof(T);
    }
}

