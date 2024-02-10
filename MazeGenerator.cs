using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour 
{
[Range(5, 500)] 
public int mazeWidth = 5, mazeHeight = 5;
public int startX, StartY;
Mazecell[,] maze;

Vector2Int currentCell;

private void start(){
    maze = new Mazecell[mazeWidth, mazeHeight];
    for (int x = 0; x < mazeWidth; x++) {
        for(int y = 0; y < mazeHeight; y++){
            maze[x, y] = new Mazecell(x, y); 
        }
    }
}


list<Direction> directions = new list<Direction> {
    Direction.Up, Direction.Down, Direction.Left, Direction.Right,
};

list 


public enum Direction {
    Up,
    Down,
    Left,
    Right, 

}


   public class Mazecell : {
    
    public bool visited;
    public Int x, y;

    public bool topwall;
    public bool leftwall;

    public vector2int position { get {
        return new Vector2Int(x, y);
    }

    }
    public Mazecell (Int x, Int y){
        this.x = x;
        this.y = y;

        visited = false;

        topwall = leftwall = true 
    }
   }

