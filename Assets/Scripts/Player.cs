using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 350f;
    private bool isDead;
//    private Rigidbody2D playerRb;
    Animator playerAnimator;
    public PlayerAnimations playerAnimations;
    public PlayerInput playerInput;
    public PlayerMovement playerMovement;


    void Awake()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
        //playerRb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
        playerMovement = GetComponent<PlayerMovement>();
    }
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        //playerRb = GetComponent<Rigidbody2D>();
        //playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0) && isDead == false)
        //{
        //    //Flap();
        //    //playerAnimations.Flap(playerRb, upForce);
        //}
        if (isDead == false)
        {
            playerMovement.JumpPlayer(playerInput.GetJumpInput(), upForce);
            playerAnimations.Flap(playerInput.GetJumpInput());
        }
    }

    //private void Flap()
    //{
        //playerRb.velocity = Vector2.zero; //Esto para que su velocidad de subida sea inalterada
        //playerRb.AddForce(Vector2.up * upForce);
        //playerAnimator.SetTrigger("Flap");
    //}

    void OnCollisionEnter2D()
    {
        Debug.Log("Colision");
        isDead = true;
        //playerAnimator.SetTrigger("Die");
        playerAnimations.Die();
        GameManager.Instance.GameOver();
    }
}
