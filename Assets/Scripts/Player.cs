using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 350f;
    private bool isDead;
    private Rigidbody2D playerRb;
    Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isDead == false)
        {
            Flap();
        }
    }

    private void Flap()
    {
        playerRb.velocity = Vector2.zero; //Esto para que su velocidad de subida sea inalterada
        playerRb.AddForce(Vector2.up * upForce);
        playerAnimator.SetTrigger("Flap");
    }

    void OnCollisionEnter2D()
    {
        Debug.Log("Colision");
        isDead = true;
        playerAnimator.SetTrigger("Die");
        GameManager.Instance.GameOver();
    }
}
