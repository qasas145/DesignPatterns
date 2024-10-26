public class BuilderSeeding {
    public void Seeding() {

        var builder = new SalaryCalculationBuilder();
        
        var customer = new Customer(){
            Id = 1,
            BaseSalary = 100,
            YearsOfExperience = 5,
            JobTitle = "Manager"
        };
        
        while (true){
            Console.WriteLine("Printing the choices");
            Console.WriteLine("\t1 - 200.5 base rate");
            Console.WriteLine("\t2 - 20 experience multiplier");
            Console.WriteLine("\t3 - 10.05 job title bonus");
            Console.WriteLine("\t0 - Exit");

            var choice = int.Parse(Console.ReadLine());
            if(choice == 1) 
                builder.WithBaseRate(200.5);
            else if (choice == 2) 
                builder.WithExperienceMultiplier(20);
            else if (choice == 3) 
                builder.WithJobTitleBonus(10.05);
            else if (choice == 0) 
                break;
        }
        var salaryCalculation = builder.Build();
        var salary = salaryCalculation.CalculateSalary(customer);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("The salary is {0}", salary);
        Console.ForegroundColor = ConsoleColor.White;

    }
}