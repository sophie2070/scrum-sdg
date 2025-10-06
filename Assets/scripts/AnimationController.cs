using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    PlayerMovement playerMovement;

    
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    void UpdateAnim()
    {
        if (playerMovement.verticalInput != 0 || playerMovement.horizontalInput != 0)
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
    }

    void Update()
    {
        UpdateAnim();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }
}
