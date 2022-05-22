using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DuckScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 7f;
    private int point = 0;
    public TMP_Text scoreDisp;
    public TMP_Text gameover;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    void GameOver ()
    {
        Time.timeScale = 0;
        gameover.text = "Game Over";
        FindObjectOfType<Clone>().StopClone();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "obstacle") {
            GameOver();
        } 
        if (other.gameObject.tag == "point") {
            scoreDisp.text = "Score : " + ++point;
        }
    }


}
