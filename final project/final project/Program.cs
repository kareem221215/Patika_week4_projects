using System;

abstract class BaseMachine
{
    public DateTime ProductionDate { get; }
    public string SerialNumber { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string OperatingSystem { get; set; }

    public BaseMachine()
    {
        ProductionDate = DateTime.Now; // Automatically assign the current date
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Production Date: {ProductionDate}");
        Console.WriteLine($"Serial Number: {SerialNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Operating System: {OperatingSystem}");
    }

    public abstract void GetProductName();
}

class Phone : BaseMachine
{
    public bool IsTurkishLicensed { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Turkish Licensed: {(IsTurkishLicensed ? "Yes" : "No")}");
    }

    public override void GetProductName()
    {
        Console.WriteLine($"Your phone's name ---> {Name}");
    }
}

class Computer : BaseMachine
{
    private int usbPortCount;
    public int UsbPortCount
    {
        get { return usbPortCount; }
        set
        {
            if (value == 2 || value == 4)
            {
                usbPortCount = value;
            }
            else
            {
                usbPortCount = -1;
                Console.WriteLine("Warning: USB Port Count can only be 2 or 4. Assigned -1.");
            }
        }
    }
    public bool HasBluetooth { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"USB Port Count: {UsbPortCount}");
        Console.WriteLine($"Has Bluetooth: {(HasBluetooth ? "Yes" : "No")}");
    }

    public override void GetProductName()
    {
        Console.WriteLine($"Your computer's name ---> {Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Press 1 to create a Phone, 2 to create a Computer:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Phone phone = new Phone();
                Console.WriteLine("Enter Serial Number:");
                phone.SerialNumber = Console.ReadLine();

                Console.WriteLine("Enter Name:");
                phone.Name = Console.ReadLine();

                Console.WriteLine("Enter Description:");
                phone.Description = Console.ReadLine();

                Console.WriteLine("Enter Operating System:");
                phone.OperatingSystem = Console.ReadLine();

                Console.WriteLine("Is it Turkish Licensed? (yes/no):");
                phone.IsTurkishLicensed = Console.ReadLine().ToLower() == "yes";

                Console.WriteLine("Phone successfully created!");
                phone.DisplayInfo();
                phone.GetProductName();
            }
            else if (choice == "2")
            {
                Computer computer = new Computer();
                Console.WriteLine("Enter Serial Number:");
                computer.SerialNumber = Console.ReadLine();

                Console.WriteLine("Enter Name:");
                computer.Name = Console.ReadLine();

                Console.WriteLine("Enter Description:");
                computer.Description = Console.ReadLine();

                Console.WriteLine("Enter Operating System:");
                computer.OperatingSystem = Console.ReadLine();

                Console.WriteLine("Enter USB Port Count (2 or 4):");
                int usbCount;
                int.TryParse(Console.ReadLine(), out usbCount);
                computer.UsbPortCount = usbCount;

                Console.WriteLine("Does it have Bluetooth? (yes/no):");
                computer.HasBluetooth = Console.ReadLine().ToLower() == "yes";

                Console.WriteLine("Computer successfully created!");
                computer.DisplayInfo();
                computer.GetProductName();
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
                continue;
            }

            Console.WriteLine("Do you want to create another product? (yes/no):");
            if (Console.ReadLine().ToLower() != "yes")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}
