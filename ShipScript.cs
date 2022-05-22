using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipScript : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    private int point = 0;
    public int health = 3;
    private bool isAlive = true;
    public TMP_Text scoreDisp;
    public TMP_Text healthDisp;
    public TMP_Text gameover;

    

    // Start is called before the first frame update
    void Start()
    {
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Vertical")){
            PlayerMove();
        }
    }

    public void Smash ()
    {
        if(!isAlive)
        {
            return;
        }
        healthDisp.text = "HEALTH: " + --health;
        if (health <= 0) 
        {
            isAlive = false;
            Destroy(gameObject);
        }
    }

    void PlayerMove() 
    {
        if(!isAlive)
        {
            return;
        }
        Vector3 dir = transform.up * Input.GetAxis("Vertical");
        transform.position = Vector3.MoveTowards(transform.position + dir * speed, transform.position, speed * Time.deltaTime);    
    }
}
