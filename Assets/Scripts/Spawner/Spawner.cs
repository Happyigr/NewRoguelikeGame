using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Mob[] _mobs;

    [SerializeField]
    private MobContainer _container;

    [SerializeField]
    private int _mobsAmount;

    [SerializeField]
    private int _mobSpawnRange;

    private Player _target;

    public void SpawnMobs()
    {
        _container.gameObject.SetActive(true);

        var containerCoords = _container.GetComponent<Transform>().position; // container must stay in a center of ro

        for (int i = 0; i < _mobsAmount; i++)
        {
            InstantiateMob(containerCoords, _target);
        }

    }
    /// <summary>
    /// initialized the target (player)
    /// </summary>
    public void Init(Player target)
    {
        _target = target;
    }

    private void InstantiateMob(Vector3 centerOfRoom, Player target)
    {
        var spawnCoords = new Vector3(centerOfRoom.x + Random.Range(-_mobSpawnRange, _mobSpawnRange), centerOfRoom.y + Random.Range(-_mobSpawnRange, _mobSpawnRange), 0);
        var mob = _mobs[Random.Range(0, _mobs.Length)];
        var createdMob = Instantiate(mob, spawnCoords, Quaternion.identity, _container.GetComponent<Transform>());
        createdMob.Init(target);
    }
}
