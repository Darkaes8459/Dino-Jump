using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur2 : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;

    Rigidbody2D rb;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("down"))
        {
            crouch.SetActive(false);
            stand.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }

}
