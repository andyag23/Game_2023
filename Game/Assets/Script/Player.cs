using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected override void Update()
    {
        GetInput();

        base.Update();
    }

    private void GetInput()
    {
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += transform.forward * -1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += transform.right * -1;
        }
    }
}
