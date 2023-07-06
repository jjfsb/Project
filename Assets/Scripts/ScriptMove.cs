using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMove : MonoBehaviour
{
    private Transform sp1Trans;
    public float movePercent = 0.01f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        sp1Trans = GameObject.Find("Script1").transform;
        animator = GetComponent<Animator>();
        animator.Play("Walk");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, sp1Trans.position, movePercent);
        if (Mathf.Abs( Vector2.Distance(transform.position,sp1Trans.position))<0.01f)
        {
            animator.Play("Idle");
        }
    }
}
