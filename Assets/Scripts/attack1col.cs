﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack1col : MonoBehaviour {

    public int dmg = 20;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.isTrigger != true && col.CompareTag("Player2"))
        {
            col.SendMessageUpwards("TakeDamage", dmg);
        }
    }

}
