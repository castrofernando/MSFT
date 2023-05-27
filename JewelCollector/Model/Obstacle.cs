namespace JewelCollector.Model;

public class Obstacle : Cell
{
    public Obstacle(int x, int y, ObstacleType type) : base(x, y)
    {
        this.Type = type;

        switch (type)
        {
            case ObstacleType.TREE:{
                this.Symbol = "$$";
                break;
            }
            case ObstacleType.WATER: {
                this.Symbol = "##";
                break;
            }
        
            default:{
                throw new InvalidDataException("Invalid obstacle type.");
            }
        }
    } 

    public ObstacleType Type { get; set; }
    public string Symbol { get; set; }

    public override void PrintCell(){
        if(Type == ObstacleType.TREE){
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(this.ToString());
        }else if(Type == ObstacleType.WATER){
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(this.ToString());
        }
    }

    public override string ToString()
    {
        return this.Symbol;
    }
}
