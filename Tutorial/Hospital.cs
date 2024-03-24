namespace Tutorial
{
    internal class Hospital
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("kavindu",2002,"ccc");
            

            Doctor doctor2 = new Doctor("Charith",2002,"eee");

            doctor2.Name = "pradeep";

            Console.WriteLine(doctor1.Id);
            Console.WriteLine(doctor2.Name);

        }
    }
}

