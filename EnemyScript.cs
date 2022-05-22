using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Vector2 dir = new Vector2(-0.02f, 0);

    GameObject clone1;
    GameObject clone2;
    GameObject clone3;

    public GameObject bullet;
    
    void Awake()
    {
        Destroy(gameObject, 7f);
    }

    float timePassed = 0f;
    void Update()
    {
        transform.Translate(dir);
        timePassed += Time.deltaTime;
        if(timePassed > 1f){
            clone1 = Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 45f));
            clone2 = Instantiate(bullet, transform.position, transform.rotation);
            clone3 = Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, -45f));
            timePassed = 0f;
        }
    }
}
