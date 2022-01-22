using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// romm should be a square
public class MyRoom : MonoBehaviour
{
    [SerializeField]
    private int roomSize;

    [SerializeField]
    private MyOpenings doors;

    [SerializeField]
    private MyOpenings walls;

    public void Setup(List<Vector2Int> config)
    {
        foreach (var wall in walls.GetOpenings())
        {
            bool contains = config.Contains(wall.Pos);
            wall.GameObject.SetActive(!contains);
        }
    }
    
    public int GetRoomSize()
    {
        return roomSize;
    }
}
