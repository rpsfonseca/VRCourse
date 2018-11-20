using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WavingZeus : Interactable
{
    public Animator animator;

    public override void StartInteraction()
    {
        animator.SetBool("shouldWave", true);
    }

    public override void EndInteraction()
    {
        animator.SetBool("shouldWave", false);
    }
}
