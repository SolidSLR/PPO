using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : Person {

    public string Work(){

        return "Menuda lata el trabajar.";

    }

    public Villager(string newName){

        speed = 50;

        maxLife = 100;

        actualLife = maxLife;

        name = newName;

        Debug.Log("Soy el aldeano bien construido");
    }

    public override string ToString(){

        /*return "Buenas tardes. Mi nombre es "+name+" y soy un aldeano. Tengo una vida sencilla, "+
        "de hecho tengo "+maxLife+" puntos de vida no hago pupas. También soy rápido, me muevo a "+speed+" pies cada seis segundos.";*/

        return base.ToString()+" A parte de eso, soy un humilde aldeano.";


    }
}
