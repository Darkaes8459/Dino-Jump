using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosour : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;

    Rigidbody2D rb;
    bool isJump;

    public GameManager gameManager;

    AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpSound = GetComponent<AudioSource>();
        isJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && isJump == false)
        {
            rb.velocity = new Vector3(0, 22, 0);
            isJump = true;

            jumpSound.Play();
        }
        if (Input.GetKey("down")&& isJump == false)
        {
            crouch.SetActive(true);
            stand.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJump = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }
}
