using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 350f;
    private bool isDead;
    Animator playerAnimator;
    public PlayerAnimations playerAnimations;
    public PlayerInput playerInput;
    public PlayerMovement playerMovement;


    void Awake()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
        playerInput = GetComponent<PlayerInput>();
        playerMovement = GetComponent<PlayerMovement>();
    }


    void Start()
    {
        isDead = false;
    }


    void Update()
    {

        if (isDead == false)
        {
            playerMovement.JumpPlayer(playerInput.GetJumpInput(), upForce);
            playerAnimations.Flap(playerInput.GetJumpInput());
        }
    }

    void OnCollisionEnter2D()
    {
        isDead = true;
        playerAnimations.Die();
        GameManager.Instance.GameOver();
    }
}
