using System;

public class GenericList<T> 
{
    //field
	const int DefaultCapacity = 4096;

	private T[] elements;
	private int count = 0;

    //constructor
	public GenericList(int capacity)
	{
		elements = new T[capacity];
	}

	public GenericList() : this(DefaultCapacity)
	{
	}

    //property
	public int Count 
	{
		get 
		{
			return this.count;
		}
	}
    public T this[int index]
    {
        get
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T result = elements[index];
            return result;
        }
    }

    //method
    public void Add(T element)
	{
		if (count >= elements.Length) 
		{
			throw new IndexOutOfRangeException(String.Format(
				"The list capacity of {0} was exceeded.", elements.Length));
		}
		this.elements[count] = element;
		count++;
	}

    
}
