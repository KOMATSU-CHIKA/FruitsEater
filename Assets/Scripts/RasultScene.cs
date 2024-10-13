using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RasultScene : MonoBehaviour
{
    public void goTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void retry()
    {
        SceneManager.LoadScene("InGame");
    }
}
