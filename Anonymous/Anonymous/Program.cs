internal class Program
{
    public delegate void myDelegate(int num1, int num2);
    private static void Main(string[] args)
    {
        /*var student1 = new { name = "Shehran", age = 22, course = "ADSE" };
        
        Console.WriteLine(student1.age);
        */

        /*myDelegate md = delegate (int value1, int value2)
         {
               Console.WriteLine(value1 + value2);
         };
         md(50, 20);*/

        /* string stdname = "Mudassir";
         Console.WriteLine(stdname.myString());*/

        /*Person1 myperson = new Person1();

          myperson.personName();
          Console.WriteLine("-----------------");
          myperson.personAge();

          */

        string stdname = "Shehran";
        int stdage = 20;
        char? course = null;
        string future = null ?? "Bohat acha ha";

        Console.WriteLine("Student Name is : "+stdname);
        Console.WriteLine("Student Age is : " + stdage);

        if (course.HasValue)
        {
            Console.WriteLine("Student course is : " + course);
        }
        else {
            Console.WriteLine("not enrolled in any course ");
        }

        Console.WriteLine("Student Future is : " + future);

    }
}

    public static class myExtension {
public static string myString(this string myname) {
 return myname;
}

}

public partial class Person1 {

    public void personName() {
        Console.WriteLine("This is from person 1");
    }

}

public partial class Person1 {

    public void personAge() {
        Console.WriteLine("This is from Person 2");
    }

}