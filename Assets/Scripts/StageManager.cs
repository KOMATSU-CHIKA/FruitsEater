using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : LoadStage
{
    public static StageManager instance;

    [SerializeField] Text mission;
    [SerializeField] GameObject clear;
    [SerializeField] GameObject gameOver;

    bool clearFlg = false;
    bool gameOverFlg = false;

    int ClearNum;
    List<int> ClearList  = new List<int>();

    [Tooltip("‰Ê•¨‚ªo‚éŠÔ‚ÌŠî€’l")]
    float spawnTimer = 2.0f;

    [HideInInspector] public Dictionary<int, float> RaneX = new Dictionary<int, float>()
    {
        {0, -0.75f},
        {1, -0.25f},
        {2, 0.25f},
        {3, 0.75f}
    };

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        ClearNum = Random.Range(2, 6);
        for(int i = 0; i<ClearNum; i++)
        {
            ClearList.Add(Random.Range(0, (int)FruitsManager.fruits.max));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStop())
        {
            return;
        }

        spawnTimer -= Time.deltaTime;
        if(spawnTimer < 0)
        {
            FruitsManager.instance.addRane();
            spawnTimer = Random.Range(0, 2f);
        }
    }

    public bool isGameStop()
    {
        return clearFlg || gameOverFlg;
    }

    public void ClearCheck(int fruitType)
    {
        if (isGameStop())
        {
            return;
        }

        ClearList.Remove(fruitType);
        mission.text = $"{ClearNum - ClearList.Count} / ?";

        if(ClearList.Count == 0)
        {
            clearFlg = true;
            clear.SetActive(true);
        }
    }

    public void GameOver()
    {
        gameOverFlg = true;
        gameOver.SetActive(true);
    }
}
