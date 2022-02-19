using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObserver : MonoBehaviour
{
    [SerializeField]
    private Player _player;

    private Transform _plTrans;

    private void Start()
    {
        _plTrans = _player.GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = new Vector3(_plTrans.position.x, _plTrans.position.y, -10);
    }
}
