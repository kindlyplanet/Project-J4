using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
   
   private const string IS_WALKING = "IsWalking";
   private const string IS_JUMPING = "IsJumping";
   private const string LEFT_PUNCH = "LeftPunch";
   private const string RIGHT_PUNCH = "RightPunch"; 

   [SerializeField] private Player player;
   private Animator animator; 
   
   private void Awake() 
   {
      animator = GetComponent<Animator>();
   }

   private void Update() 
   {
      animator.SetBool(IS_WALKING,player.IsWalking());
      animator.SetBool(IS_JUMPING,player.IsJumping());
      
   }

    public void AttackAnimation(string animationName)
    {
        animator.SetTrigger(animationName);
    }
}
