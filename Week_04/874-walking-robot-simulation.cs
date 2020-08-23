public class Solution 
{
    public int RobotSim(int[] commands, int[][] obstacles) 
    {
        if(commands == null ||  commands.Length == 0) return 0;

        var x = 0;
        var y = 0;
        var xDir = new int[4] {0, -1, 0, 1}; // 90, 180, 270, 0
        var yDir = new int[4] {1, 0, -1, 0};
        var aindex = 0;      
        var max = 0;

        var obSet = new HashSet<(int, int)>();
        foreach(var ob in obstacles)
        {
            obSet.Add((ob[0], ob[1]));            
        }

        foreach(int command in commands)
        {
            if(command == -2) // Turn left
            {                
                aindex = aindex == 3 ? 0 : ++aindex;  
            }
            else if(command == -1) // Turn right
            {                
                aindex = aindex == 0 ? 3 : --aindex;
            }
            else
            {               
                for(int i = 1; i <= command; i++)
                {   
                    x += xDir[aindex];
                    y += yDir[aindex];  
                                   
                    if(obSet.Contains((x, y))) 
                    {
                        x -= xDir[aindex];
                        y -= yDir[aindex];
                        break;
                    }                 

                    max = Math.Max(max, x*x+y*y);
                }                
            }
        }
       
        return max;
    }   
}