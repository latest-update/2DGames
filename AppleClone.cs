using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleClone : MonoBehaviour
{
    public GameObject original;
    GameObject clone;
    private int i = 0;
    bool cloning = true;
    [SerializeField] private int interval = 100;

    // Update is called once per frame
    void Update()
    {
        if (!cloning) {
            return;
        }
        i += 1;
        if (i > interval) {
            clone = Instantiate(original, transform.position, transform.rotation);
            clone.transform.position = new Vector2(Random.Range(-10f, 10f), transform.position.y);
            i = 0;
        }
    }

    public void DecreaseInterval()
    {
        interval -= 20;
        FindObjectOfType<SpeedSpriteScript>().operation();
        Debug.Log("New Interval " + interval);
    }
}
