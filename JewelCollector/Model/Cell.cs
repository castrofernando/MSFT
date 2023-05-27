namespace JewelCollector.Model;

public abstract class Cell
{
    public Cell(int x, int y)
    {
        PosX = x;
        PosY = y;
    }
    public int PosX { get; set; }
    public int PosY { get; set; }


    public abstract void PrintCell();
}
