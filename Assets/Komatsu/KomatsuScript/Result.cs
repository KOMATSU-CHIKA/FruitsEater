using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false;

    public void PressTitle()
    {
        Debug.Log("Press Start!");
        if (!firstPush)
        {
            //soundManager.PlaySe(clip);
            Debug.Log("Go Title!");
            //ここに次のシーンへいく命令を書く。
            SceneManager.LoadScene("title");
            //
            firstPush = true;
        }
    }
    public void PressRetry()
    {
        Debug.Log("Press Start!");
        if (!firstPush)
        {
            //soundManager.PlaySe(clip);
            Debug.Log("Go Game");
            //ここに次のシーンへいく命令を書く。
            SceneManager.LoadScene("SampleScene");
            //
            firstPush = true;
        }
    }
}
