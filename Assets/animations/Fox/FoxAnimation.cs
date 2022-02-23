using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxAnimation : MonoBehaviour
{

    Animator animator;

    [SerializeField]
    KeyCode L;

    public float animationTimer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(L))
        {
            animationTimer = 1.75f;
            animator.SetInteger("State", 1);


        }

        if (animationTimer > 0)
        {
            animationTimer -= Time.deltaTime;
        }
        else
        {
            animator.SetInteger("State", 0);

        }
            
    }
}
