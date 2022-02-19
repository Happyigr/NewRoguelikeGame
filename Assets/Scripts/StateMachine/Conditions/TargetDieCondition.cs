using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDieCondition : Condition
{
    private void Update()
    {
        if (Target == null)
        {
            NeedTransit = true;
        }
    }
}
