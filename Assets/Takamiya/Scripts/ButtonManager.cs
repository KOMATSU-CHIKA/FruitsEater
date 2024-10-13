using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stage1LoadScene()
    {
        Initiate.Fade("InGame", Color.black, 1.0f);
    }

    public void Stage2LoadScene()
    {
        Initiate.Fade("Stage2", Color.black, 1.0f);
    }
}
