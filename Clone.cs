using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    public GameObject original;
    GameObject clone;
    private int i = 0;
    bool cloning = true;
    [SerializeField] private int obstacle = 380;
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
            clone.transform.position = new Vector2(transform.position.x, Random.Range(-2, 0.5f));
            i = 0;
        }
    }

    public void StopClone () {
        cloning = false;
    }
}
