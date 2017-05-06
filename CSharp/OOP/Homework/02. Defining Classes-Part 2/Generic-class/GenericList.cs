using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GenericList<T> where T : IComparable
{

    //fields
    private T[] objectList;
    private int capacity;
    internal const int maxCapacity = 8000;
    internal const int defaultCapacity = 16;
    private int length;



    //constructors
    public GenericList() : this(defaultCapacity)
    {
    }
    public GenericList(int capacity)
    {
        this.objectList = new T[capacity];
        this.length = 0;
        this.Capacity = capacity;
    }

    //Properties
    ////Capacity
    public int Capacity
    {
        get
        {
            return capacity;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("ArgumentOutOfRange_NegativeCapacity");
            }
            if (value > MaxCapacity)
            {
                throw new ArgumentOutOfRangeException("ArgumentOutOfRange_Capacity");
            }
            if (value < this.Length)
            {
                throw new ArgumentOutOfRangeException("ArgumentOutOfRange_SmallCapacity");
            }
            this.capacity = value;
        }
    }

    ////Access
    public T this[int index]
    {
        get
        {
            if (index >= length || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T result = objectList[index];
            return result;
        }
    }
    public int Length
    {
        get
        {
            return length;
        }
    }

    
    internal static int DefaultCapacity
    {
        get
        {
            return defaultCapacity;
        }
    }

    internal static int MaxCapacity
    {
        get
        {
            return maxCapacity;
        }
    }


    //Methods
    ////Add
    public void Add(T newObject)
    {
        if (this.length + 1 > this.capacity)
        {
            throw new InvalidOperationException("Capacity is full.");
        }
        this.objectList[this.length] = newObject;
        this.length++;
    }

    ////Remove
    public object Remove(int index)
    {
        if (index < 0 || index >= this.length)
        {
            throw new ArgumentOutOfRangeException(
            "Invalid index: " + index);
        }
        object releasedObject = this.objectList[index];
        for (int i = index; i < this.length - 1; i++)
        {
            this.objectList[i] = this.objectList[i + 1];
        }
        this.objectList[this.length - 1] = default(T);
        this.length--;
        return releasedObject;
    }
    ////Insert
    public object Insert(T insertedObject, int index)
    {
        if (this.length + 1 > this.capacity)
        {
            throw new InvalidOperationException("Index is out of Capacity range.");
        }
        if (index < 0 || index > this.length)
        {
            throw new ArgumentOutOfRangeException(
            "Index is out of Length range.");
        }
        this.length++;

        for (int i = this.length - 1; i > index; i--)
        {
            this.objectList[i] = this.objectList[i - 1];
        }
        this.objectList[index] = insertedObject;
        return insertedObject;
    }
    ////Find
    public object Find(object value)
    {

        string miss = "value not found";
        int index;
        for (int i = 0; i < this.length; i++)
        {
            if ((this.objectList[i]).Equals(value))
            {
                index = i;
                return index; break;
            }
        }
        return miss;
    }
    ////Clear
    public void Clear()
    {
        int tempLength = this.length;
        for (int i = 0; i < tempLength; i++)
        {
            this.objectList[i] = default(T);
            this.length--;
        }
    }
    ////Double Capacity
    //////Variant 1 - Just increase Capacity (intList.Capacity = ....)

    //////Variant 2
    public void DoubleListSize()
    {
        T[] oldElements = this.objectList;
        this.Capacity *= 2;
        this.objectList = new T[Capacity];
        Array.Copy(oldElements, this.objectList, this.Length);
        int newCapacity = this.capacity * 2;
    }
    public T Min()
    {
        T min = default(T);

        if (this.Length > 0)
        {
            min = this.objectList[0];
            foreach (T item in this.objectList)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            
        }

        return min;
    }

    public T Max()
    {
        if ((this.Length) == 0)
        {
            throw new ArgumentException("There are no elements in this list");
        }
        T max = default(T);

        foreach (T item in this.objectList)
        {
            if (max.CompareTo(item) < 0)
            {
                max = item;
            }
        }
        return max;
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        for (int index = 0; index < this.Length; index++)
        {
            result.AppendLine(String.Format("{0,-5}{1}", String.Format("[{0}] = ", index), this.objectList[index]));
        }

        return result.ToString().Trim();
    }
}