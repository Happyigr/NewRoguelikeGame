using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCondition : Condition
{
    [SerializeField] private float _time;

    private void OnEnable()
    {
        StartCoroutine("WaitForTime", _time);
    }

    private IEnumerator WaitForTime(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Debug.Log('a');
        NeedTransit = true;
    }

    private void OnDisable()
    {
        StopCoroutine("WaitForTime");
    }
}
