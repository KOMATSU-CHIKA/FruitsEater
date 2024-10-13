using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitManager : MonoBehaviour
{
    Rigidbody rb;
    float speed = 3.0f;

    bool isAkey = false;
    bool isDkey = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (isAkey)
        {
            rb.MovePosition(new Vector3(-30, 0, 0));
            isAkey = false;
        }
        else if (isDkey)
        {
            rb.MovePosition(new Vector3(30, 0, 0));
            isDkey = false;
        }
        //Dキーで右に移動
        if (Input.GetKeyDown(KeyCode.D))
        {
            isDkey=true;
        }
        //Aキーで左に移動
        if (Input.GetKeyDown(KeyCode.A))
        {
            isAkey=true;
        }
    }
}
