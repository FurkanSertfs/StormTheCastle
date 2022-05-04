using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenSprite : MonoBehaviour
{

    void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
       // BoxCollider2D boxCollider2D = GetComponent<BoxCollider2D>();

        float cameraHeight = Camera.main.orthographicSize*2;
        Vector2 cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
        Vector2 spriteSize = spriteRenderer.sprite.bounds.size;
       // Vector2 boxColliderSize = boxCollider2D.size;

        Vector2 scale = transform.localScale;
        if (cameraSize.x >= cameraSize.y)
        { // Landscape (or equal)
            scale *= cameraSize.x / spriteSize.x;
        }
        else
        { // Portrait
            scale *= cameraSize.y / spriteSize.y;
        }

        transform.position = Vector2.zero; // Optional
        transform.localScale = scale;
    //   boxCollider2D.size = new Vector2(scale.x*19.2f, scale.y * 5.4f);
    //    boxCollider2D.offset = new Vector2(boxCollider2D.offset.x, -scale.y * 5.4f/2);
    }
    private void Start()
    {
        gameObject.SetActive(false);
        gameObject.SetActive(true);

    }
}