public class SalaryCalculationBuilder {
    
    private double BaseRate { get; set; }
    private double ExperienceMultiplier { get; set; }
    private double JobTitleBonus { get; set; }

    public SalaryCalculationBuilder WithBaseRate(double baseRate) {
        BaseRate = baseRate;
        return this;
    }
    public SalaryCalculationBuilder WithJobTitleBonus(double jobTitleBonus) {
        JobTitleBonus = jobTitleBonus;
        return this;
    }
    public SalaryCalculationBuilder WithExperienceMultiplier(double experienceMultiplier) {
        ExperienceMultiplier = experienceMultiplier;
        return this;
    }
    public SalaryCalculation Build() {
        Console.WriteLine("{0}, {1}, {2}", BaseRate, ExperienceMultiplier, JobTitleBonus);
        var salaryCalculation = new SalaryCalculation(BaseRate, ExperienceMultiplier, JobTitleBonus);
        return salaryCalculation;
    }
}