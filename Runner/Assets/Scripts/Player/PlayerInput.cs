using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovier))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovier _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMovier>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            _mover.TryMoveUp();

        if (Input.GetKeyDown(KeyCode.S))
            _mover.TryMoveDown();

    }

}
