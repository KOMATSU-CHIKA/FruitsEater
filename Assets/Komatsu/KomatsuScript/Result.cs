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
            //�����Ɏ��̃V�[���ւ������߂������B
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
            //�����Ɏ��̃V�[���ւ������߂������B
            SceneManager.LoadScene("SampleScene");
            //
            firstPush = true;
        }
    }
}
