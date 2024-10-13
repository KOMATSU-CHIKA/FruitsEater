using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    [SerializeField] GameObject option;
    bool isTuoch = false;

    public void PressStart()
    {
        Debug.Log("Press Start!");
        Initiate.Fade("StageSlectScene", Color.black, 1.0f);
    }
    public void Option()
    {
        if (!isTuoch)
        {
            option.SetActive(true);
        }
        else
        {
            option.SetActive(false);
        }
        isTuoch = !isTuoch;
        
    }

    private void Update()
    {
        endGame();
    }

    public void endGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
        }


    }

}
    

