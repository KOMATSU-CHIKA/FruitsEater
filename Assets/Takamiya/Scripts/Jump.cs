using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump: MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow) ||Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jump",true);
        }
    }
}
