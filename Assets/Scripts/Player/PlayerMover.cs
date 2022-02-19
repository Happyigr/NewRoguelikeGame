using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    [SerializeField]
    private Weapon _weapon;

    [SerializeField]
    private float _forcePower;

    private Rigidbody2D _rb;
    private Vector3 _cursorPos;
    private bool _isRight = true;

    private void OnEnable()
    {
        _weapon = GetComponentInChildren<Weapon>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        _rb.velocity = new Vector2(0, 0);
        _rb.AddForce(movement * _forcePower);

        TryToMirror();
    }

    private void TryToMirror()
    {
        // player mirroring
        _cursorPos = _mainCamera.ScreenToViewportPoint(Input.mousePosition);
        // if cursorPos.x > 0.5 => right half of screen
        if (_cursorPos.x > 0.5 && !_isRight)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            _weapon.GetComponent<LookAtCursor>().Flip();
            _isRight = true;
        }

        if (_cursorPos.x < 0.5 && _isRight)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            _weapon.GetComponent<LookAtCursor>().Flip();
            _isRight = false;
        }
    }
}
