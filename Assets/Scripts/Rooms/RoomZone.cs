using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoomZone : MonoBehaviour
{
    public UnityAction IsEntered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            IsEntered.Invoke();
        }
    }
}
