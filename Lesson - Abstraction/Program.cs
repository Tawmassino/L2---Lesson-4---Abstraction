namespace Lesson___Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kvadratas = new Square(3,4,3,4);
            var trikampis = new Triangle(5,5,7);

            Console.WriteLine($"The area of your rectangle is {kvadratas.GetArea()}");
            Console.WriteLine($"The perimeter of your rectangle is {kvadratas.GetPerimeter()}");
            

            Console.WriteLine($"The area of your triangle is {trikampis.GetArea()}");
            Console.WriteLine($"The perimeter of your triangle is {trikampis.GetPerimeter()}");

            //kvadratas.GetArea2()//reikia nurodyti is naujo kintamuosius ir galima prideti kazka naujo
           ;
        }
    }
}