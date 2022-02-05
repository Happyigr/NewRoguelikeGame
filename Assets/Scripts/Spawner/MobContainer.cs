using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MobContainer : MonoBehaviour
{
    public UnityAction IsEmpty;

    private void Update()
    {
        var mobs = GetComponentsInChildren<Mob>();

        if (mobs.Length == 0)
        {
            IsEmpty?.Invoke();
            gameObject.SetActive(false);
        }
    }
}
