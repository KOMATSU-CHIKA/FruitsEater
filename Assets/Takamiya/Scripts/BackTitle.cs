using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BackTitleButton()
    {

        Initiate.Fade("Title", Color.black, 1.0f);
    }
}
