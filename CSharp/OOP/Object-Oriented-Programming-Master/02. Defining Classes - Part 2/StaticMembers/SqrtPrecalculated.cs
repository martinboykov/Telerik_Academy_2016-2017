//Формално погледнато, статичен член(static member) на класа наричаме всяко поле, свойство, метод или друг член, който има модификатор static в декларацията си1.Това означава, че полета, методи и свойства маркирани като статични, принадлежат на самия клас, а не на някой конкретен обект от дадения клас.
//Следователно, когато маркираме поле, метод или свойство като статични, можем да ги използваме, без да създаваме нито един обект от дадения клас.Единственото, от което се нуждаем е да имаме достъп (видимост) до класа, за да можем да извикваме статичните му методи, или да достъпваме статичните му полета и свойства.
//----------------------------------------------------
//Статичните елементи на класа могат да се използват без да се създава обект от дадения клас.
//----------------------------------------------------
//Всички обекти, създадени по описанието на един клас споделят статичните полета на класа.
//----------------------------------------------------



using System;

class SqrtPrecalculated //може да има само статични членове (полета, свойства и конструктори)
{
    public const int MAX_VALUE = 10000;
    public static int Prop {get; set;}
    // Static field
    private static int[] sqrtValues; //не можем да защитим данните в масива (винаги може да се бърка и да се променят данните (не е като string)

    // Static constructor???? (precalculated values of Sqrt)
    static SqrtPrecalculated()
    {
        sqrtValues = new int[MAX_VALUE + 1];
        for (int i = 0; i < sqrtValues.Length; i++)
        {
            sqrtValues[i] = (int) Math.Sqrt(i);
        }
    }

    //static property
    public static int Sqrt200
    {
        get
        {
            return sqrtValues[200];
        }
    }

    // Static method 
    public static int GetSqrt(int value)
    {
        return sqrtValues[value];
    }

    // The Main() method is always static
    static void Main()
    {

        //--------------------------------------------------
        //ако класа е static не можем да дефинираме инстанция
        //SqrtPrecalculated instance = new SqrtPrecalculated(); //няма да се компилира

        //ако класа не е static ще можем да дефинираме инстанция
        // SqrtPrecalculated instance = new SqrtPrecalculated();//ще се компилира


        //--------------------------------------------------
        //ако свойството "Prop" е статично няма да можем да го достъпваме през инстанцията, но ще можем да го достъпваме през класа
        // Console.WriteLine(instance.Prop); //няма да се компилира
        //Console.WriteLine(SqrtPrecalculated.Prop); //ще се компилира

        //ако свойството "Prop" не е статично ще можем да го достъпваме през инстанцията, но няма да можем да го достъпваме през класа
        // Console.WriteLine(instance.Prop); //ще се компилира
        //Console.WriteLine(SqrtPrecalculated.Prop); //няма да се компилира
        //--------------------------------------------------

        Console.WriteLine(SqrtPrecalculated.GetSqrt(254));
        Console.WriteLine(SqrtPrecalculated.Sqrt200);
    }
}
