using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Start ()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player") {
            FindObjectOfType<Hero>().TallJump();
            spriteRenderer.enabled = false;
            transform.position = RandomPoint();
            spriteRenderer.enabled = true;
        }
    }

    private static Vector2 RandomPoint() {
        return new Vector2(
            Random.Range(-7f, 7f),
            Random.Range(-1.5f, 1.5f)
        );
    }
}
