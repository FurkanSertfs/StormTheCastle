using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullcollider : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider2D;
    Vector2 cameraSize;
    Vector2 spriteSize;
    Vector2 boxColliderSize;
    Vector2 scale;
    void Start()
    {
        

        float cameraHeight = Camera.main.orthographicSize*2;
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
        spriteSize = spriteRenderer.sprite.bounds.size;
        boxColliderSize = boxCollider2D.size;
        scale = transform.localScale;

        if (cameraSize.x >= cameraSize.y)
        {  
            scale *= cameraSize.x / spriteSize.x;
            
        }
        else
        { // Portrait
            scale *= cameraSize.y / spriteSize.y;
            
        }
       
        transform.position = Vector2.zero; // Optional
        transform.localScale = scale;
        boxCollider2D.size = new Vector2(scale.x * 19.2f, scale.y * 10.4f);
        boxCollider2D.offset = new Vector2(boxCollider2D.offset.x, -scale.y * 10.4f / 4);

    }
    
}
