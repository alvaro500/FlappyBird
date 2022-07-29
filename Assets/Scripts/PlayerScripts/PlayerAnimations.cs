using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator playerAnimator;

    public void Flap(Rigidbody2D playerRgb2D, float force)
    {
        playerRgb2D.velocity = Vector2.zero;
        playerRgb2D.AddForce(Vector2.up * force);
        playerAnimator.SetTrigger("Flap");
    }

    public void Die()
    {
        playerAnimator.SetTrigger("Die");
    }
}
