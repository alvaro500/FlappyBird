using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRb;

    // Start is called before the first frame update
    void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    public void JumpPlayer(bool jump, float force)
    {
        if (jump)
        {
            playerRb.velocity = Vector2.zero;
            playerRb.AddForce(Vector2.up * force);
        }
    }
}
