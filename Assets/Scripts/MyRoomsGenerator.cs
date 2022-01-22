using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRoomsGenerator : MonoBehaviour
{
    [SerializeField]
    private MyRoom roomPrefab;

    [SerializeField]
    private MyRoom bossRoomPrefab;

    [SerializeField]
    private Grid mapHolder;

    [SerializeField]
    private int amountOfRooms;

    private void Start()
    {
        Generate(amountOfRooms);
    }

    private void Generate(int amount)
    {
        MyGraph graph = new MyGraph();
        var nodeInfos = graph.Generate(amount);
        foreach (var nodeInfo in nodeInfos)
        {
            var room = Instantiate(roomPrefab, new Vector3(nodeInfo.Pos.x, nodeInfo.Pos.y, 0) * roomPrefab.GetRoomSize(), Quaternion.identity, mapHolder.GetComponent<Transform>());
            room.Setup(nodeInfo.Dirs);
        }
    }
}
