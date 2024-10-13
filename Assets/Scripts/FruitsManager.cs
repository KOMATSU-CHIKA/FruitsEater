using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FruitsManager : MonoBehaviour
{
    public static FruitsManager instance;

    [SerializeField] Object[] fruitsObj;

    public enum fruits
    {
        apple,
        banana,
        persimmon, //Š`
        peach,
        pear, //—œ

        max
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void addRane()
    {
        int raneNum = Random.Range(0, 4);
        float RaneX = StageManager.instance.RaneX.Where(e => e.Key == raneNum).FirstOrDefault().Value;

        Instantiate(fruitsObj[Random.Range(0, fruitsObj.Length)], new Vector3(RaneX, 0, 20), Quaternion.identity);
    }
}
