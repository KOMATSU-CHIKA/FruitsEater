using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : ItemBase
{
    [SerializeField] FruitsManager.fruits fruit;
    [SerializeField] GameObject normal;
    [SerializeField] GameObject cut;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RabbitCollider")
        {
            normal.SetActive(false);
            cut.SetActive(true);

            StageManager.instance.ClearCheck((int)fruit);
        }
    }
}
