﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy, IDamageable
{
    public int Health { get; set; }

    //Use for initialize
    public override void Init()
    {
        base.Init();
        Health = base.health;
    }

    public void Damage()
    {
        Debug.Log("Damage()");
        Health--;
        anim.SetTrigger("Hit");
        isHit = true;
        anim.SetBool("InCombat", true);

        if (Health < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
