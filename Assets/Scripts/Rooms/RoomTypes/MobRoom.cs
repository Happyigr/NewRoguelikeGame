using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobRoom : Room
{
    [SerializeField]
    private Spawner _spawner;

    [SerializeField]
    private RoomZone _roomZone;

    private bool _wasStarted = false;

    private void OnEnable()
    {
        _roomZone.IsEntered += OnRoomEntered;
    }

    private void OnDisable()
    {
        _roomZone.IsEntered -= OnRoomEntered;
    }

    public void OnRoomEntered()
    {
        StartRoom();
    }

    private void StartRoom()
    {
        if (!_wasStarted)
        {
            _spawner.SpawnMobs();
        }

        _wasStarted = true;
    }
}

