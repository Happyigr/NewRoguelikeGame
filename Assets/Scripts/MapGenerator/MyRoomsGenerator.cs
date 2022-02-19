using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRoomsGenerator : MonoBehaviour
{
    [SerializeField]
    private Room[] _roomPrefabs;

    [SerializeField]
    private Room _startRoomPrefab;

    [SerializeField]
    private Room _bossRoomPrefab;

    [SerializeField]
    private Grid _mapHolder;

    [SerializeField]
    private int _amountOfRooms; // boss room not included

    [SerializeField]
    private int _amountOfChestRooms;

    [SerializeField]
    private int _amountOfMobRooms;

    private void Start()
    {
        Generate(_amountOfRooms);
    }

    private void Generate(int amount)
    {
        MyGraph graph = new MyGraph();
        var nodeInfos = graph.Generate(amount);
        bool startRoomSpawned = false;
        foreach (var nodeInfo in nodeInfos)
        {
            if (!startRoomSpawned)
            {
                var room = Instantiate(_startRoomPrefab, new Vector3(nodeInfo.Pos.x, nodeInfo.Pos.y, 0) * _startRoomPrefab.GetRoomSize(), Quaternion.identity, _mapHolder.GetComponent<Transform>());
                room.Setup(nodeInfo.Dirs);

                startRoomSpawned = true;
            }
            else
            {
                var room = Instantiate(RandomRoomPrefab(), new Vector3(nodeInfo.Pos.x, nodeInfo.Pos.y, 0) * RandomRoomPrefab().GetRoomSize(), Quaternion.identity, _mapHolder.GetComponent<Transform>());
                room.Setup(nodeInfo.Dirs);
            }
        }
    }

    private Room RandomRoomPrefab()
    {
        return _roomPrefabs[Random.Range(0, _roomPrefabs.Length)];
    }
}
