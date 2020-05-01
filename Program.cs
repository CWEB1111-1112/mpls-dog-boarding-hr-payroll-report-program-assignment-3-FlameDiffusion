using System;
/**
Name: 
Date of completion:

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            int x = 0;
            Boolean loop = true;
            string [] employeeName = new string [10];
            int [] depNumber = new int [10];
            double [] salary = new double [10];
            double [] hoursWorked = new double [10]; 
            double [] grossSalary = new double [10];
            string [] depName = {"n/a","Personnel","Marketing","Care and Support","Information Technology","Sales","Legal","Accounting"};

            while(loop == true){
                string check = "y";
                Console.WriteLine("Enter the employee's name");
                employeeName [x] = Console.ReadLine();
                Console.WriteLine("Enter your department number 1.Personnel 2.Marketing 3.Care and Support 4.Information Technology 5.Sales 6.Legal 7.Accounting");
                depNumber [x] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter their salary");
                salary [x] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter how many hours they worked");
                hoursWorked [x] = Convert.ToDouble(Console.ReadLine());
                grossSalary[x] = salary[x] * hoursWorked[x];
                Console.WriteLine("do you want to add a another employee (y/n)");
                check = Console.ReadLine();
                if(check == "y"){
                    x++;
                }else{
                    loop = false;
                }
                
                
            }
            
            for(var i = 0; i < x+1; i++){
                int j = depNumber[i];
                Console.WriteLine($"Employee Name:{employeeName[i]} / Department name:{depName[j]} / gross salary:{grossSalary[i]}");
            }

            double [] payroll = new double [7];
            for(var i = 0; i < payroll.Length; i++){
                for(var j = 0; j < employeeName.Length; j++){
                    if(depNumber[j] == i+1){
                        payroll[i] = payroll[i] + grossSalary[j];
                    }
                }
            }

            Console.WriteLine("1.Personnel: $" + payroll[0]);
            Console.WriteLine("2.Marketing: $" + payroll[1]);
            Console.WriteLine("3.Care and Support: $" + payroll[2]);
            Console.WriteLine("4.Information Technology: $" + payroll[3]);
            Console.WriteLine("5.Sales: $" + payroll[4]);
            Console.WriteLine("6.Legal: $" + payroll[5]);
            Console.WriteLine("7.Accounting: $" + payroll[6]);
            
            

            
                
        }

    }
}
