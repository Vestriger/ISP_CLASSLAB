using System;
using System.Collections.Generic;

namespace lab_3
{
    
    public class StudentOfPrograming : Student
    {
        public StudentOfPrograming()
        {
            Intelligence = 100;
        }

        public void Sleep()
        {
            SleptWell = true;
        }

        public void Sleep(int hours)
        {
            SleptWell = true;
            if (hours > 8)
            {
                Intelligence++;
            }
        }
        
        private int _numberOfPrograms;

        public void WriteProgram()
        {
            Console.WriteLine("The program is being written...");
            _numberOfPrograms++;
            Console.WriteLine($"Congratulations!!! That is your {_numberOfPrograms} program!");
            if (SleptWell)
            {
                Intelligence += 4;
                SleptWell = false;
            }
            else
            {
                Intelligence += 2;
                Console.WriteLine("You could learn more if you slept well!");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine($"Student : {Name} {Lastname}");
            Console.WriteLine("Specialty : Programing");
            Console.WriteLine($"Group : {Group}");
            Console.WriteLine($"Slept well : {SleptWell}");
            Console.WriteLine($"Number of written programs : {_numberOfPrograms}");
            Console.WriteLine($"The unique id : {Student.Id}");
            Console.WriteLine($"Intelligence : {Intelligence}");
            Console.WriteLine("*********************************"); 
        }
    }
    public class Students
    {
        private List<StudentOfPrograming> students = new List<StudentOfPrograming>();
        public StudentOfPrograming this[int index]
        {
            get
            {
                if (index < 0 && index >= students.Count)
                {
                    throw new Exception("There is no student with this index\n");
                }
                return students[index];
            }
            set => students.Add(value);
        }
    }
    
    
    
}