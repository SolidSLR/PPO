using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unidades {

    protected int maxLife, actualLife;

    private Vector3 dimensions;

    private float vision;

    protected string name;

    public string BeingAttacked(int damage){

        actualLife = actualLife-damage;

        return "Ah! Estoy siendo asaltado. Me hacen "+damage+" pupas y me quedan "+actualLife;

    }

    public void Spawn(){

         Debug.Log("Toma! Teño vida!");
    }

    public void Die(){

        //Destroy(self);

        Debug.Log("RIP");
    }

    public bool CanDie(){

        if(actualLife>0){

            Debug.Log("JAJA, sigo vivo");

            return false;

        }else{

            Debug.Log("Maldita sea, morí");

            Die();

            return true;

        }
    }
}
