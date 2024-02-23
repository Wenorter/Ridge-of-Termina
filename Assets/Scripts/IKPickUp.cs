using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKPickUp : MonoBehaviour
{
    public Transform target; // the object that the hand will reach for
    public Transform rightHand; // the hand that will be adjusted by the IK
    public float weight = 1.0f; // the weight of the IK adjustment (0.0f = no adjustment, 1.0f = full adjustment)
    public string animationName; // the name of the animation that should use the IK adjustment

    private Animator animator; // the animator component of the character
    private int animationHash; // the hash code of the animationName string

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnAnimatorIK(int layerIndex)
    {
        // set the position and rotation of the right hand to match the target
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, weight);
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, weight);
        animator.SetIKPosition(AvatarIKGoal.RightHand, target.position);
        animator.SetIKRotation(AvatarIKGoal.RightHand, target.rotation);
        
    }
    void Update(){}
}





