public class Tools
{
   public static List<string> asciiarts = new List<string>(){
        @"
                .--.
        |__| .-------.
        |=.| |.-----.|
        |--| || KCK ||
        |  | |'-----'|
        |__|~')_____('
        ",
        @"
         ______
        | |__| |
        |  ()  |
        |______|

        "
    };

    public static string Input(string label){
        Console.WriteLine(label);
        return Console.ReadLine()??"";
    }
    public static decimal InputDecimal(string label)
    {
        decimal result = 0;
        decimal.TryParse(Input(label), out result); 
        return result;
    }


}