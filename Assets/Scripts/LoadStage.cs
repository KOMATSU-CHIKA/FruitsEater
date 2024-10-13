using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UnityEngine;
using Random = UnityEngine.Random;

public class PhaseData
{
    public List<float> beats;
    public List<FruitsManager.fruits[]> fruit;
    public List<FruitsManager.fruits> fruitAssign;
    public List<bool[]> isEat;
    public List<bool> eatAssign;
}

public class LoadStage : MonoBehaviour
{
    public JsonData LoadJson(int stageNum, int phaseNum)
    {
        string jsonText = Resources.Load<TextAsset>($"StageData/Stage{stageNum}/Phase{phaseNum + 1}").ToString();
        JsonData jsondata = JsonMapper.ToObject<JsonData>(jsonText);

        return jsondata;
    }

    //    public List<PhaseData> GetStageData(int stageNum)
    //    {
    //        int maxPhase = 3;
    //        List<PhaseData> phases = new List<PhaseData>();

    //        for(int k = 0; k < maxPhase; k++)
    //        {
    //            JsonData SelectionalData = LoadJson(stageNum, k)["SelectionalData"];
    //            JsonData usedata = SelectionalData[Random.Range(0, SelectionalData.Count)];
    //            PhaseData phase = new PhaseData();
    //            for (int i = 0; i < usedata["probability"].Count; i++)
    //            {
    //                int minFruitNum = (int)usedata["minNum"][i];
    //                int maxFruitNum = (int)usedata["maxNum"][i];
    //                int fruitNumDiff = maxFruitNum - minFruitNum;

    //                int fruitNum = minFruitNum;
    //                if (fruitNumDiff == 0)
    //                {
    //                    for (int j = 0; j < fruitNumDiff; j++)
    //                    {
    //                        fruitNum += (int)usedata["probability"][i] > Random.Range(0, 101) ? 1 : 0;
    //                    }

    //                    if (fruitNum != 0)
    //                    {

    //                        //phase.beats.Add((float)usedata["beats"][i]);
    //                    }
    //                }

    //                FruitsManager.fruits[] appearFruits = new FruitsManager.fruits[fruitNum];
    //                FruitsManager.fruits assignFruits;
    //                bool[] isEat = new bool[fruitNum];
    //                bool assignEat;
    //                for (int j = 0; j < fruitNum; j++)
    //                {
    //                    appearFruits[j] = (FruitsManager.fruits)Enum.ToObject(typeof(FruitsManager.fruits), Random.Range(0, (int)FruitsManager.fruits.max));
    //                    isEat[j] = Random.Range(0, 2) == 0;
    //                }

    //                if (appearFruits.Length > 0)
    //                {

    //                    while (true)
    //                    {
    //                        int rand = Random.Range(0, appearFruits.Length);

    //                        if ((int)appearFruits[rand] < (int)FruitsManager.fruits.wood)
    //                        {
    //                            assignFruits = appearFruits[rand];
    //                            assignEat = isEat[rand];
    //                            break;
    //                        }
    //                    }


    //                    phase.fruit.Add(appearFruits);
    //                    phase.fruitAssign.Add(assignFruits);
    //                    phase.isEat.Add(isEat);
    //                    phase.eatAssign.Add(assignEat);
    //                }
    //            }
    //        }

    //        return phases;
    //    }
}
