using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Military {

    private int rangeAttack;
    public Archer(string newName, int newAttackP){

        name = newName;

        rangeAttack = 20;

        attackPower = 5;

    }
}


