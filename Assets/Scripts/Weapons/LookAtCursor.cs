using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LookAtCursor : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    [SerializeField]
    private int _offSet;

    private bool isFlipped = false;

    private void Update()
    {
        // look at cursore
        Vector3 diffirence = _mainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(diffirence.y, diffirence.x) * Mathf.Rad2Deg;
        if(!isFlipped)
            transform.localRotation = Quaternion.Euler(0f, 0f, rotZ + _offSet);
        else
            transform.localRotation = Quaternion.Euler(0f, 180f, rotZ + _offSet);
    }

    public void Flip()
    {
        isFlipped = !isFlipped;
    }
}
