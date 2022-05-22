using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite explosion;
    Vector2 dir = new Vector2(-0.04f, 0);

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Destroy(gameObject, 3f);    
    }

    void Update()
    {
        transform.Translate(dir);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player") {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            FindObjectOfType<ShipScript>().Smash();
            spriteRenderer.sprite = explosion;
            StartCoroutine(ExplosionCoroutine());
        }
    }

    IEnumerator ExplosionCoroutine()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }

}
