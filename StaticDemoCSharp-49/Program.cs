namespace StaticDemoCSharp_49;

class Program
{
    static void Main(string[] args)
    {

        var x = 5;
        var y = 10;

        Console.WriteLine(MathHelper.Add(3, 3));

        var storedReturn = MathHelper.Add(x, y);

        var classroomOne = new Classroom();
        var classroomTwo = new Classroom();

        classroomTwo.Teacher = "Mack";
        classroomOne.Teacher = "Seth";

        Console.WriteLine(classroomOne.Teacher);
        Console.WriteLine(classroomTwo.Teacher);

        Console.WriteLine(Classroom.Subject);
        
        Greet();


    }

    public static void Greet()
    {
        Console.WriteLine("Hello!");
    }
}
