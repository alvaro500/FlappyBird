using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool inputButton;

    //void Update()
    //{
    //    GetJumpInput();
    //}

    public bool GetJumpInput()
    {
        //inputButton = Input.GetMouseButtonDown(0);
        //return inputButton;

        //return inputButton = Input.GetMouseButtonDown(0);
        return Input.GetMouseButtonDown(0);
    }

}
