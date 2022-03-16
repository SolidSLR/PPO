using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : PlayableChar {

    protected float speed;

    public static string[] names = {"Santiago","Karool","Borja","Ricardo","Juan","Miguel","Alberto","Antía","Elías","Isaac"};


    public string GroundMovement(){

        return "Me muevo en tierra a "+speed+", ni me acerques al agua";
    }

    /*public Person(){

        //Debug.Log("Son unha persoa chamada "+name);

    }*/

    public string MyName(){

        return name;
    }

    public override string ToString(){

        return "Hola, mi nombre es "+name+". Mi vida máxima es "+maxLife+" y mi vida actual es "+actualLife+". Me muevo a "+speed+" pies/6 segundos.";

    }
}

