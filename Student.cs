using System;

namespace lab_3
{
    public class Student : Human
    {
        protected Student()
        {
            Intelligence = 90;
            SleptWell = false;
        }
        protected static Guid Id = Guid.NewGuid();
        public int Group { get; set; }

        public void GoToUniversity()
        {
            Console.WriteLine("Student going to the University...");
            if (SleptWell)
            {
                Intelligence += 3;
                SleptWell = false;
            }
            else
            {
                Console.WriteLine("You so tired and sleep during class!!!");
            }
        }
    }
}