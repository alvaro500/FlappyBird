using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator playerAnimator;

    int flapHashCode;
    int dieHasCode;

    private void Start()
    {
        // StringToHash nos ayuda a optimizar un poco las animaciones
        flapHashCode = Animator.StringToHash("Flap");
        dieHasCode = Animator.StringToHash("Die");
    }

    public void Flap(bool jump)
    {
        if (jump)
        {
            playerAnimator.SetTrigger(flapHashCode);
        }
    }

    public void Die()
    {
        playerAnimator.SetTrigger(dieHasCode);
    }
}
