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

    public void SpawnMobs()
    {
        _container.gameObject.SetActive(true);

        var containerCoords = _container.GetComponent<Transform>().position;

        for (int i = 0; i < _mobsAmount; i++)
        {
            var spawnCoords = new Vector3(containerCoords.x + Random.Range(-_mobSpawnRange, _mobSpawnRange), containerCoords.y + Random.Range(-_mobSpawnRange, _mobSpawnRange), 0);
            var mob = _mobs[Random.Range(0, _mobs.Length)];
            Instantiate(mob, spawnCoords, Quaternion.identity, _container.GetComponent<Transform>());
        }

    }
}
