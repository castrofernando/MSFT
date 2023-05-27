namespace JewelCollector.Model;

public class Game
{
    private readonly int rows = 10;
    private readonly int cols = 10;

    public delegate void keyboardHandler(char key);
    public event keyboardHandler onKeyUpPress;
    public event keyboardHandler onKeyDownPress;
    public event keyboardHandler onKeyLeftPress;
    public event keyboardHandler OnKeyRightPress;     

    public Game()
    {
        this.Map = new Map(rows,cols);
        this.Robot = new Robot(0,0);
        TotalBagItens = 0;
        BagTotalValue =0;
        GenerateElements();
    }
    public Map Map { get; set; }
    public int TotalBagItens { get; set; }
    public int BagTotalValue { get; set; }
    public Robot Robot { get; set; }

    private void GenerateElements(){
        Map.InitMap();
        Map.Add(new Jewel(1,9,JewelType.RED));
        Map.Add(new Jewel(8,8,JewelType.RED));

        Map.Add(new Jewel(9,1,JewelType.GREEN));
        Map.Add(new Jewel(7,6,JewelType.GREEN));

        Map.Add(new Jewel(3,4,JewelType.BLUE));
        Map.Add(new Jewel(2,1,JewelType.BLUE));

        for (int i = 0; i < 6; i++)
        {
            Map.Add(new Obstacle(5,i, ObstacleType.WATER));
        }

        Map.Add(new Obstacle(5,9, ObstacleType.TREE));
        Map.Add(new Obstacle(3,9, ObstacleType.TREE));
        Map.Add(new Obstacle(8,3, ObstacleType.TREE));
        Map.Add(new Obstacle(2,5, ObstacleType.TREE));
        Map.Add(new Obstacle(1,4, ObstacleType.TREE));
        
        Map.Add(Robot);

        Map.Print();
    }
    public void Start(){
        bool running = true;
        do {

            Console.Write("Enter the command: ");
            var command = Console.ReadKey();
            Console.WriteLine();

            if (command.KeyChar.Equals('q')) {
                running = false;
            } else if (command.KeyChar.Equals('w')) {
                Robot.MoveUp(Map);
            } else if (command.KeyChar.Equals('a')) {
                Robot.MoveLeft(Map);
            } else if (command.KeyChar.Equals('s')) {
                Robot.MoveDown(Map);
            } else if (command.KeyChar.Equals('d')) {
                Robot.MoveRight(Map);
            } else if (command.KeyChar.Equals('g')) {
                
            }
            Map.Print();
        } while (running);
    }
}
