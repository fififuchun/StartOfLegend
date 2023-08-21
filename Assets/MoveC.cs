using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveC : MonoBehaviour
{

    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;
        }
        
        this.transform.position = pos;
    }
}
