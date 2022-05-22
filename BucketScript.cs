using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BucketScript : MonoBehaviour
{
    public TMP_Text scoreDisp;
    public TMP_Text healthDisp;
    public TMP_Text gameOver;

    private int point = 0;
    public int health = 3;

    private bool isAlive = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(isAlive){
            Vector2 mouseCoord = Input.mousePosition;
            Vector2 mouseCoordCamera = Camera.main.ScreenToWorldPoint(mouseCoord);
            transform.position = new Vector2(mouseCoordCamera[0], -4);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "apple") {
            intoBucket();
            Destroy(other.gameObject);
        }
    }

    private void intoBucket()
    {
        scoreDisp.text = "POINT: " + ++point;
        if(point % 10 == 0)
        {
            FindObjectOfType<AppleClone>().DecreaseInterval();
        }
    }

    public void DecreaseHealth()
    {
        if(!isAlive){
            return;
        }
        healthDisp.text = "HEALTH: " + --health;
        if(health <= 0) 
        {
            isAlive = false;
            gameOver.text = "GAME OVER";
        }
    }
}
