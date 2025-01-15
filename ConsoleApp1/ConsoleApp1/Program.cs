using System;
internal class Program
{
    static void Main(string[] args)
    {

        Student std1 = new Student()
        {
            stdName = "Ali",
            StdEmail = "ali@gmail.com"
        };

        //std1.stdName = "Hamza";

        Student std2 = new Student()
        {
            stdName = "Ali",
            StdEmail = "ali@gmail.com"
        };

        Console.WriteLine(std1 == std2);
        //Console.WriteLine(std1);

    }

}
public record Student
{
    public required string stdName { get; init; }
    public required string StdEmail { get; init; }
};