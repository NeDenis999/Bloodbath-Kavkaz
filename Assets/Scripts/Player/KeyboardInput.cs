using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;
    [SerializeField] private Player _player;

    private float _horizontal = 0f;
    private float _vertical = 0f;

    private void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump"))
            _movement.Jump();

        _movement.Move(new Vector2(_horizontal, 0));

        if (Input.GetButtonDown("Ability"))
            _player.TimeDilation(0.5f);

        if (Input.GetButtonUp("Ability"))
            _player.TimeDilation(1f);
    }

    private void FixedUpdate()
    {

    }
}
