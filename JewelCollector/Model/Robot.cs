namespace JewelCollector.Model;

public class Robot : Cell
{
    public Robot(int x, int y) :base(x,y)
    {

    }

    public int Energia { get; set; }

    public void MoveUp(Map map){
        if(this.PosX-1 < 0){
            Console.WriteLine("Invalid Position. Try again.");
        }else if(map.Position[this.PosX-1, this.PosY] == null){
            map.Position[this.PosX, this.PosY] = null;
            this.PosX--;
            map.Position[this.PosX, this.PosY] = this;
            Energia--;
        }
    }

    public void MoveDown(Map map){
        if(this.PosX+1 >= map.Rows){
            Console.WriteLine("Invalid Position. Try again.");

        }else if(map.Position[this.PosX+1, this.PosY] == null){
            map.Position[this.PosX, this.PosY] = null;
            this.PosX++;
            map.Position[this.PosX, this.PosY] = this;
            Energia--;
        }
    }

    public void MoveLeft(Map map){
        if(this.PosY-1 < 0){
            Console.WriteLine("Invalid Position. Try again.");

        }else if(map.Position[this.PosX, this.PosY-1] == null){
            map.Position[this.PosX, this.PosY] = null;
            this.PosY--;
            map.Position[this.PosX, this.PosY] = this;
            Energia--;
        }
    }

    public void MoveRight(Map map){
        if(this.PosY+1 >= map.Columns){
            Console.WriteLine("Invalid Position. Try again.");
        }else if(map.Position[this.PosX, this.PosY+1] == null){
            map.Position[this.PosX, this.PosY] = null;
            this.PosY++;
            map.Position[this.PosX, this.PosY] = this;
            Energia--;
        }
    }
    public override void PrintCell(){
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(this.ToString());    
    }

    public override string ToString()
    {
        return "ME";;
    }
}
