using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Military : Person {

    protected int attackPower;

    private int attackRange;

    public int Attack(){

        if(CanDie()){

            return 0;
            
        }

        Debug.Log("Jaja, soy "+name+" y  te voy a pinxar");

        return attackPower;

    }

    public Military(){

        speed = 40;

        maxLife = 500;

        actualLife = maxLife;

        Debug.Log("Soy un militar, donde te pinxo?");
    }

    public override string ToString(){

        /*return "Buenas tardes. Mi nombre es "+name+" y soy un militar. Soy muy fuerte "+
        "porque tengo "+maxLife+" puntos de vida y pego leches que hacen "+attackPower+" pupas. También soy rápido, me muevo a "+speed+" pies cada seis" 
        +" segundos.";*/

        return base.ToString()+" Soy un militar muy militar y soy capaz de hacer "+attackPower+" pupas. Tenga usted cuidado conmigo.";
    }
}
