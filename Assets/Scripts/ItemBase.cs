using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static FruitsManager;

public class ItemBase : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.position -= new Vector3(0, 0, speed) * Time.deltaTime;
    }
}
