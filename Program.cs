namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           DuplicateElementFromArray array1 = new DuplicateElementFromArray();
            array1.find();

            Console.WriteLine();

            Student student1 = new Student();
            student1.isEligible();

            Electricitybill electricitybill = new Electricitybill();
            electricitybill.display();
        }
    }
}
