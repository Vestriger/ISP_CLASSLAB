namespace lab_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student1 = new StudentOfPrograming();
            var student2 = new Student();
            student2.Name = "Vlad";
            student2.Lastname = "Jameson";
            student2.Group = 503505;
            student2.PrintInfo();
            for (int i = 0; i < 7; i++)
            {
              student2.Sleep(10);  
              student2.GoToUniversity();
            }
            student2.Ability();
            student1.Name = "Vlad";
            student1.Lastname = "Jameson";
            student1.Group = 503505;
            student1.PrintInfo();
            student1.Sleep(10);
            student1.WriteProgram();
            student1.PrintInfo();
            student1.Ability();
            var students = new Students();
            students[0] = student1;
            students[0].Sleep();
            students[0].WriteProgram();
            students[0].PrintInfo();
            students[1] = new StudentOfPrograming();
            students[1].Name = "Vadim";
            students[1].Lastname = "Kopchik";
            students[1].Group = 666999;
            students[1].PrintInfo();


        }
    }
}