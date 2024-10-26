public class SalaryCalculation
{
    private double BaseRate { get; set; }
    private double ExperienceMultiplier { get; set; }
    private double JobTitleBonus { get; set; }

    public SalaryCalculation(double baseRate, double experienceMultiplier, double jobTitleBonus)
    {
        BaseRate = baseRate;
        ExperienceMultiplier = experienceMultiplier;
        JobTitleBonus = jobTitleBonus;
    }

    public double CalculateSalary(Customer customer)
    {
        double experienceBonus = customer.YearsOfExperience * ExperienceMultiplier;
        double jobBonus = customer.JobTitle == "Manager" ? JobTitleBonus : 0;
        double totalSalary = customer.BaseSalary + (BaseRate * customer.BaseSalary) + experienceBonus + jobBonus;
        
        return totalSalary;
    }
}
