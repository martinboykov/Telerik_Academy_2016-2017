public class Person
{
    private string name; //always private (for control)
    private int age; //always private (for control)

    // Default constructor
    public Person()
    {
        this.name = null;
        this.age = 0;
    }

    // Constructor with parameters
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    //property
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    //property
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
}