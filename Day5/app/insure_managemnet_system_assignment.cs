using System;
using System.Collections.Generic;
sealed class Security
{
    public void Authenticate()
    {
        Console.WriteLine("User authenticated successfully\n");
    }
}


abstract class InsurancePolicy
{
    public int PolicyNumber { get; init; }

    private double premium;
    public double Premium
    {
        get { return premium; }
        set
        {
            if (value > 0)
                premium = value;
            else
                Console.WriteLine("Premium must be greater than zero");
        }
    }

    public string PolicyHolderName { get; set; }

    public virtual double CalculatePremium()
    {
        return Premium;
    }

    public void ShowPolicy()
    {
        Console.WriteLine("Insurance Policy");
    }
}


class LifeInsurance : InsurancePolicy
{
    private const double LifeCharge = 500;

    public override double CalculatePremium()
    {
        return Premium + LifeCharge;
    }

    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}

class HealthInsurance : InsurancePolicy
{
    public sealed override double CalculatePremium()
    {
        return Premium + 1000;
    }
}

class PolicyDirectory
{
    private List<InsurancePolicy> policies = new List<InsurancePolicy>();

    public void AddPolicy(InsurancePolicy policy)
    {
        policies.Add(policy);
    }

    public InsurancePolicy this[int index]
    {
        get { return policies[index]; }
    }

    public InsurancePolicy this[string name]
    {
        get
        {
            foreach (var policy in policies)
            {
                if (policy.PolicyHolderName == name)
                    return policy;
            }
            return null;
        }
    }
}

// 5. Main Program
class Ram
{
    
    static void Main(string[] args)
    {
        Ram.Aspar();   
    }

    // Method called from Main
    static void Aspar()
    {
        Security security = new Security();
        security.Authenticate();

        LifeInsurance life = new LifeInsurance
        {
            PolicyNumber = 101,
            PolicyHolderName = "Amit",
            Premium = 5000
        };

        HealthInsurance health = new HealthInsurance
        {
            PolicyNumber = 102,
            PolicyHolderName = "Neha",
            Premium = 7000
        };

        PolicyDirectory directory = new PolicyDirectory();
        directory.AddPolicy(life);
        directory.AddPolicy(health);

        Console.WriteLine(directory[0].PolicyHolderName);
        Console.WriteLine(directory["Neha"].PolicyNumber);

        InsurancePolicy p1 = life;
        InsurancePolicy p2 = health;

        Console.WriteLine("Life Premium: " + p1.CalculatePremium());
        Console.WriteLine("Health Premium: " + p2.CalculatePremium());

        life.ShowPolicy();  
        p1.ShowPolicy();    
    }
}
