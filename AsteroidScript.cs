using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite explosion;
    Vector2 dir = new Vector2(-0.02f, 0);
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir);
        Destroy(gameObject, 7f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        spriteRenderer.sprite = explosion;
        if (other.gameObject.tag == "player") {
            FindObjectOfType<ShipScript>().Smash();
        }
        StartCoroutine(ExplosionCoroutine());
    }

    IEnumerator ExplosionCoroutine()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
}
