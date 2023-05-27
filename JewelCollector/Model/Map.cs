namespace JewelCollector.Model;

public class Map
{
    public Map(int x, int y)
    {
        Rows=x;
        Columns=y;
        Position = new Cell[x,y];
    }

    public int Columns { get; set; }
    public int Rows { get; set; }
    public Cell[,] Position { get; set; }

    public void Add(Cell obj){
        Position[obj.PosX, obj.PosY] = obj;
    }

    public void Remove(int x, int y){
        Position[x,y] = null;
    }

    public void InitMap(){
        for (int x = 0; x < Rows; x++)
        {
            for (int y = 0; y < Columns; y++)
            {
                Position[x,y] = null;
            }
        }
    }

    public void Print(){
        for (int x = 0; x < Rows; x++)
        {
            Utils.ResetConsoleColor();
            //quebra de linha por row
            Console.WriteLine();
            for (int y = 0; y < Columns; y++)
            {
                if(Position[x,y]==null){
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("--");
                    continue;
                }
                Position[x,y].PrintCell();
            }
        }
        //quebra de linha ao final da matrix
        Utils.ResetConsoleColor();
        Console.WriteLine();

    }
}
