using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveC : MonoBehaviour
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

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
            spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
            spriteRenderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;

        }
        
        rigidbody.position = pos;
    }
}
