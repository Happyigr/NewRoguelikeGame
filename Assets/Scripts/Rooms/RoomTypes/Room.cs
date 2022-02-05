using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// romm should be a square
public class Room : MonoBehaviour
{
    [SerializeField]
    private int _roomSize;

    [SerializeField]
    private MyOpenings _doors;

    public void Setup(List<Vector2Int> config)
    {
        foreach (var wall in _doors.GetOpenings())
        {
            bool contains = config.Contains(wall.Pos);
            wall.GameObject.SetActive(!contains);
        }
    }

    public int GetRoomSize()
    {
        return _roomSize;
    }
}
