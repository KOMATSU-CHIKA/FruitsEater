using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class RabbitController : MonoBehaviour
{
    [SerializeField] Object[] rane;
    [SerializeField] BoxCollider[] col;
    [SerializeField] float speed;

    Transform transform;
    

    bool isMove = false;

    int currentRane;
    int oldRane;
    float currentXLine;


    void Start()
    {
        transform = GetComponent<Transform>();
        currentRane = 0;
        currentXLine = transform.position.x;
    }

    void FixedUpdate()
    {
        if (StageManager.instance.isGameStop())
        {
            return;
        }

        if(Vector3.Distance(transform.position, new Vector3(currentXLine, transform.position.y, transform.position.z)) < 0.1f)
        {
            if (isMove)
            {
                isMove = false;
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(currentXLine, transform.position.y, transform.position.z), speed * Time.deltaTime);
    }

    void Update()
    {
        if (StageManager.instance.isGameStop())
        {
            return;
        }

        if (isMove)
        {
            return;
        }

        if (currentXLine < 0.7f && Input.GetKeyDown(KeyCode.RightArrow))
        {
            isMove = true;
            oldRane = currentRane;
            currentRane += 1;
            col[oldRane].enabled = false;
            col[currentRane].enabled = true;
            currentXLine = StageManager.instance.RaneX.Where(e => e.Key == currentRane).FirstOrDefault().Value;
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if (currentXLine > -0.7f && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isMove = true;
            oldRane = currentRane;
            currentRane -= 1;
            col[oldRane].enabled = false;
            col[currentRane].enabled = true;
            currentXLine = StageManager.instance.RaneX.Where(e => e.Key == currentRane).FirstOrDefault().Value;
            transform.eulerAngles = new Vector3(0, -90, 0);
        }
    }
}
