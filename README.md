# Letterxpress
Letterxpress.de Library

## Usage
The usage is simple. Here is an example of how your balance is displayed.  
![](https://i.imgur.com/PhHHwUt.png)

## Example
```cs
private static async Task Main(string[] args)
{
    Console.OutputEncoding = Encoding.UTF8; //Show currency symbols
    var library = new Library("abc", "123", true);
    try
    {
        var balance = await library.Pricing.GetBalanceAsync();
        var letterPrice =
            await library.Pricing.GetPriceAsync(1, true, PrintMode.SIMPLEX, Shipment.NATIONAL_GERMANY);

        Console.WriteLine($"Your balance: {balance:C}");
        Console.WriteLine("==============================================");

        Console.WriteLine($"Calculated price for the letter: {letterPrice.Price:C}");
        Console.WriteLine($"Sufficient balance: {letterPrice.Price < balance}");
        Console.WriteLine("Letter specifications:");
        Console.WriteLine($"\t\t\tColor: {letterPrice.Specification.Color == 4}");
        Console.WriteLine($"\t\t\tMode: {letterPrice.Specification.Mode}");
        Console.WriteLine($"\t\t\tPages: {letterPrice.Specification.Page}");
        Console.WriteLine($"\t\t\tShipping: {letterPrice.Specification.Ship}");
    }
    catch (InvalidApiResultException exception)
    {
        Console.WriteLine("\n=====================================================================");
        Console.WriteLine(
            $"\nError:\t\t{exception.Source}\nError:\t\t{exception.Message}\nHelp: {exception.HelpLink}");
    }
    catch (AggregateException exception)
    {
        foreach (var innerException in exception.Flatten().InnerExceptions)
        {
            Console.WriteLine("\n=====================================================================");
            Console.WriteLine(
                $"\nError!\nAPI call:\t{innerException.Source}\nError:\t\t{innerException.Message}\nHelp: {innerException.HelpLink}");
        }
    }
}
```
### Result
![](https://i.imgur.com/19krPSp.png)