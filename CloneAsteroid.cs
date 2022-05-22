using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneAsteroid : MonoBehaviour
{
    public GameObject original;
    GameObject clone;
    private int i = 0;
    bool cloning = true;
    [SerializeField] private int obstacle = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!cloning) {
            return;
        }
        i += 1;
        if (i > obstacle) {
            clone = Instantiate(original, transform.position, transform.rotation);
            clone.transform.position = new Vector2(transform.position.x, Random.Range(-3, 3));
            i = 0;
        }
    }
}
