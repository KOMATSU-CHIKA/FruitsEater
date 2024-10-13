using UnityEngine;

public class BgmSample : MonoBehaviour
{

    [SerializeField]
    SoundManager soundManager;
    [SerializeField]
    AudioClip clip;

    void Start()
    {
        soundManager.PlayBgm(clip);
    }
}