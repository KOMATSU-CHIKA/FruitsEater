using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsMoveManager : MonoBehaviour
{

    //public float speed = 10f;

    public Vector3 speed = new Vector3(0,0,10f);
    private void Start()
    {
        
    }

    void Update()
    {

        //座標を書き換える
        transform.position -= speed * Time.deltaTime;
    }
}
