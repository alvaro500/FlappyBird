﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool GetJumpInput()
    {
        return Input.GetMouseButtonDown(0);
    }

}
