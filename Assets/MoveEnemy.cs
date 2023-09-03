using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
        private Rigidbody2D rigidbody = null;
    public float speed = 0.01f;
    private SpriteRenderer spriteRenderer = null;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>(); // 「Rigidbody2D」コンポーネントの取得

        spriteRenderer = this.GetComponent<SpriteRenderer>();//「renderer」の取得
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = rigidbody.position;

        if (Input.GetKey("right"))
        {
            pos.x += speed;
            spriteRenderer.flipX = false;
        }

        if (Input.GetKey("left"))
        {
            pos.x -= speed;
            spriteRenderer.flipX = true;
        }

        if (Input.GetKey("up"))
        {
            pos.y += speed;
        }

        if (Input.GetKey("down"))
        {
            pos.y -= speed;

        }
        
        rigidbody.position = pos;
    }
}
