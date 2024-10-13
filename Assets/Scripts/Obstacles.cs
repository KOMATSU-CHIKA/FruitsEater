using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FruitsManager;

public class Obstacles : ItemBase
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RabbitCollider")
        {
            StageManager.instance.GameOver();
        }
    }
}
