using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator playerAnimator;

    public void Flap(bool jump)
    {
        if (jump)
        {
            playerAnimator.SetTrigger("Flap");
        }
        
    }

    public void Die()
    {
        playerAnimator.SetTrigger("Die");
    }
}
