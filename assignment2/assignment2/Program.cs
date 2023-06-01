using System;

public abstract class Clothing
{
    public abstract void Sales();

    public abstract void Materials();

    public abstract void CommonWear();

    public void Presentation()
    {
        Console.WriteLine("***** Blueprint Garments Presentation *****");
        Materials();
        CommonWear();
        Sales();
        Console.WriteLine("******************************************");
    }
}

public class TrendSetting : Clothing
{
    public override void Sales()
    {
        Console.WriteLine("Sales by Region (TrendSetting collection):");
        Console.WriteLine("- North America");
        Console.WriteLine("- Europe");
        Console.WriteLine("- Asia");
    }

    public override void Materials()
    {
        Console.WriteLine("Materials used in TrendSetting collection:");
        Console.WriteLine("- Wool");
        Console.WriteLine("- Hemp");
        Console.WriteLine("- Ramie");
        Console.WriteLine("- Silk");
        Console.WriteLine("- Lyocell");
    }

    public override void CommonWear()
    {
        Console.WriteLine("Common wear in TrendSetting collection:");
        Console.WriteLine("- Skirts");
        Console.WriteLine("- Trousers");
        Console.WriteLine("- Jackets");
        Console.WriteLine("- Blouses");
    }
}

public class ClimateControl : Clothing
{
    public override void Sales()
    {
        Console.WriteLine("Sales by Region (ClimateControl collection):");
        Console.WriteLine("- North America");
        Console.WriteLine("- South America");
        Console.WriteLine("- Australia");
    }

    public override void Materials()
    {
        Console.WriteLine("Materials used in ClimateControl collection:");
        Console.WriteLine("- Cotton");
        Console.WriteLine("- Linen");
        Console.WriteLine("- Polyester");
        Console.WriteLine("- Rayon");
        Console.WriteLine("- Bamboo");
    }

    public override void CommonWear()
    {
        Console.WriteLine("Common wear in ClimateControl collection:");
        Console.WriteLine("- Tops");
        Console.WriteLine("- Dresses");
        Console.WriteLine("- Shirts");
    }
}

public class Sports : Clothing
{
    public override void Sales()
    {
        Console.WriteLine("Sales by Region (Sports collection):");
        Console.WriteLine("- Europe");
        Console.WriteLine("- Asia");
        Console.WriteLine("- Africa");
    }

    public override void Materials()
    {
        Console.WriteLine("Materials used in Sports collection:");
        Console.WriteLine("- Nylon");
        Console.WriteLine("- Spandex");
        Console.WriteLine("- Polyester");
        Console.WriteLine("- Mesh");
        Console.WriteLine("- Lycra");
    }

    public override void CommonWear()
    {
        Console.WriteLine("Common wear in Sports collection:");
        Console.WriteLine("- Sportswear");
        Console.WriteLine("- Activewear");
        Console.WriteLine("- Athletic apparel");
    }
}

public class Program
{
    public static void Main()
    {
        Clothing trendSetting = new TrendSetting();
        trendSetting.Presentation();

        Console.WriteLine();

        Clothing climateControl = new ClimateControl();
        climateControl.Presentation();

        Console.WriteLine();

        Clothing sports = new Sports();
        sports.Presentation();
    }
}
