namespace JewelCollector.Model;

public class Jewel : Cell
{
    public Jewel(int x, int y, JewelType type) : base(x, y)
    {
        this.Type = type;

        switch (type)
        {
            case JewelType.RED:{
                this.Value = 100;
                this.Symbol = "JR";
                break;
            }
            case JewelType.GREEN: {
                this.Value = 50;
                this.Symbol = "JG";
                break;
            }
            case JewelType.BLUE: {
                this.Value = 10;
                this.Symbol = "JB";
                break;
            }
            default:{
                throw new InvalidDataException("Invalid jewel type.");
            }
        }
    } 

    public JewelType Type { get; set; }
    public int Value { get; set; }
    public string Symbol { get; set; }

    public override void PrintCell(){
        if(Type == JewelType.RED){
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(this.ToString());
        }else if(Type == JewelType.GREEN){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(this.ToString());
        }else if(Type == JewelType.BLUE){
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(this.ToString());
        }
    }

    public override string ToString()
    {
        return this.Symbol;
    }
}
