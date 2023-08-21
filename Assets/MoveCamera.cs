using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private GameObject chara;

    // Start is called before the first frame update
    void Start()
    {
        chara = GameObject.Find("C1");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(chara.transform.position);
        this.transform.position = chara.transform.position + new Vector3(0.0f, 0.0f, -10f); 
    }
}