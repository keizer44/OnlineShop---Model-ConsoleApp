using Задача_1.Models;

//PARTS
Processor processor1 = new Processor(1, "Intel Core I7-12700", 450m, 8);
Processor processor2 = new Processor(2, "AMD Ryzen 9 5900X", 899.99m, 12);

VideoCard videoCard1 = new VideoCard(3, "Intel UHD Graphics 770", 180m, 2, "DDR4");
VideoCard videoCard2 = new VideoCard(4, "Gigabyte nVidia GeForce RTX 3070", 1349.99m, 8, "GDDR6");

Disk disk1 = new Disk(5, "Lexar SSD NM610", 90m, "500GB", "2500 MB/s");
Disk disk2 = new Disk(6, "Western Digital HDD Purple Pro - Surveillance", 50m, "1TB", "7200 rpm");

MemoryCard memoryCard1 = new MemoryCard(7, "Adata 2G 1300", 50, 8, "DDR3");
MemoryCard memoryCard2 = new MemoryCard(8, "Patriot Viper Venom ", 719m, 32, "DDR5");

var parts = new Dictionary<int, Product>();
parts.Add(processor1.Id, processor1);
parts.Add(processor2.Id, processor2);
parts.Add(videoCard1.Id, videoCard1);
parts.Add(videoCard2.Id, videoCard2);
parts.Add(disk1.Id, disk1);
parts.Add(disk2.Id, disk2);
parts.Add(memoryCard1.Id, memoryCard1);
parts.Add(memoryCard2.Id, memoryCard2);

//COMPUTERS
var computer1 = new Computer(1, "Dell", 1500m, processor1, memoryCard1, disk1, videoCard1);
var computer2 = new Computer(2, "MSI Mag Codex", 5000m, processor2, memoryCard2, disk2, videoCard2);

var computers = new Dictionary<int, Product>();
computers.Add(computer1.Id, computer1);
computers.Add(computer2.Id, computer2);

// LAPTOPS
var laptop1 = new Laptop(1, "Acer", 4000m, processor1, memoryCard1, disk1, videoCard1);
var laptop2 = new Laptop(2, "Lenovo Legion", 4000m, processor2, memoryCard2, disk2, videoCard2);

var laptops = new Dictionary<int, Product>();
laptops.Add(laptop1.Id, laptop1);
laptops.Add(laptop2.Id, laptop2);

ShowMenu();

var userInput = Console.ReadLine();
var order = new Order();

while (userInput != "4")
{
    if (userInput == "1")
    {
        foreach (var kvp in computers)
        {
            var product = (Computer)kvp.Value;

            Console.WriteLine($"ID: {product.Id} - {product.Name} - {product.Price}lv.");
            Console.WriteLine($"--{product.Processor.Name} {product.Processor.Cores} cores");
            Console.WriteLine($"--{product.MemoryCard.Name} {product.MemoryCard.MemoryCapacity} {product.MemoryCard.MemoryType}");
            Console.WriteLine($"--{product.HardDisk.Name} {product.HardDisk.Capacity} {product.HardDisk.Speed}");
            Console.WriteLine($"--{product.VideoCard.Name} {product.VideoCard.MemoryCapacity}");
            Console.WriteLine();
        }

        Console.WriteLine("1.Make Order");
        Console.WriteLine("2.Back");

        var input = Console.ReadLine();

        if (input == "1")
        {
            MakeOrder(computers, order);
        }

        else if (input == "2")
        {
            ShowMenu();
            userInput = Console.ReadLine();
        }
    }

    else if (userInput == "2")
    {
        foreach (var kvp in laptops)
        {
            var product = (Laptop)kvp.Value;

            Console.WriteLine($"ID: {product.Id} - {product.Name} - {product.Price}lv.");
            Console.WriteLine($"--{product.Processor.Name} {product.Processor.Cores} cores");
            Console.WriteLine($"--{product.MemoryCard.Name} {product.MemoryCard.MemoryCapacity} {product.MemoryCard.MemoryType}");
            Console.WriteLine($"--{product.HardDisk.Name} {product.HardDisk.Capacity} {product.HardDisk.Speed}");
            Console.WriteLine($"--{product.VideoCard.Name} {product.VideoCard.MemoryCapacity}");
            Console.WriteLine();
        }

        Console.WriteLine("1.Make Order");
        Console.WriteLine("2.Back");
        var input = Console.ReadLine();

        if (input == "1")
        {
            MakeOrder(laptops, order);
        }

        else if (input == "2")
        {
            ShowMenu();
            userInput = Console.ReadLine();
        }
    }

    else if (userInput == "3")
    {
        foreach (var computerPart in parts)
        {
            Console.WriteLine(computerPart);
        }

        Console.WriteLine("1.Make Order");
        Console.WriteLine("2.Back");

        var input = Console.ReadLine();

        if (input == "1")
        {
            MakeOrder(parts, order);
        }

        else if (input == "2")
        {
            ShowMenu();
            userInput = Console.ReadLine();
        }
    }
}

Console.WriteLine("Your Order:");
foreach (var product in order.Products)
{
    Console.WriteLine($"{product.Name} - {product.Price}lv.");
}

Console.WriteLine($"Total: {order.Products.Select(p => p.Price).Sum()}lv.");

static void ShowMenu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("Choose by Category:");
    Console.WriteLine("1.Computers");
    Console.WriteLine("2.Laptops");
    Console.WriteLine("3.Computer Parts");
    Console.WriteLine("4.Exit");
}

static void MakeOrder(Dictionary<int, Product> products, Order order)
{
    Console.WriteLine("Enter the desired product ID and type \"end\" when finish:");
    string input = Console.ReadLine();

    while (input != "end")
    {

        int id = int.Parse(input);

        if (products.ContainsKey(id))
        {
            order.Products.Add(products[id]);
        }
        else
        {
            Console.WriteLine("Invalid input");
            Console.WriteLine("Again!!");
        }

        input = Console.ReadLine();
    }
}