
using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;


public class Title : MonoBehaviour
{
    [SerializeField]
    SoundManager soundManager;
    [SerializeField]
    AudioClip clip;
    [SerializeField, Min(0)]
    float waitTime = 0.5f;

    bool isPlaying = false;
    WaitForSeconds wait;

    //


    private bool firstPush = false;

    public void PressStart()
    {
        Debug.Log("Press Start!");
        if (!firstPush)
        {
            soundManager.PlaySe(clip);
            Debug.Log("Go Next Scene!");
            //‚±‚±‚ÉŸ‚ÌƒV[ƒ“‚Ö‚¢‚­–½—ß‚ğ‘‚­B
            SceneManager.LoadScene("SampleScene");
            //
            firstPush = true;
        }
    }
    
}
