using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSpriteScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite arrow;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void operation()
    {
        StartCoroutine(ArrowAppearCoroutine());
    }

    IEnumerator ArrowAppearCoroutine()
    {
        spriteRenderer.sprite = arrow;

        yield return new WaitForSeconds(3f);
        
        spriteRenderer.sprite = null;
    }

}
