using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;


    private void Awake()
    {
        if(TryGetComponent(out MoveAction moveAction))
        {
            moveAction.OnStartMoving += MoveActionOnOnStartMoving;
            moveAction.OnStopMoving += MoveActionOnOnStopMoving;
        }
        if(TryGetComponent(out ShootAction shootAction))
        {
            shootAction.OnShoot += ShootAction_OnShoot;
        }
    }

    private void ShootAction_OnShoot(object sender, EventArgs e)
    {
        animator.SetTrigger("Shoot");
    }

    private void MoveActionOnOnStopMoving(object sender, EventArgs e)
    {
        animator.SetBool("IsWalking", false);
    }

    private void MoveActionOnOnStartMoving(object sender, EventArgs e)
    {
        animator.SetBool("IsWalking", true);
    }
}
