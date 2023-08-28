using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private PlayerAnimator panimator;

    private void Start()
    {
        panimator = GetComponentInChildren<PlayerAnimator>();
    }

    private void Update()
    {
        // Ataque 1: Por ejemplo, usando la tecla "J"
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            panimator.AttackAnimation("LeftPunch");

        }

        // Ataque 2: Por ejemplo, usando la tecla "K"
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            panimator.AttackAnimation("RightPunch");
        }
    }


}
