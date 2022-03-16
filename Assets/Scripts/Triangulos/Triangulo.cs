using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo
{
    private float lado;

    private static float cantidadeTriangulos = 0;

    public float CalcularArea(){
        //base*altura/2

        float altura = (Mathf.Sqrt(3*lado))/2;

        return altura;
    }

    public static float CalcularAreaStatic(float lado, float b){

        return b*lado/2;

    }

    public static float showCant(){

        return cantidadeTriangulos;

    }

    public Triangulo(float newLado){

        lado = newLado;

        cantidadeTriangulos++;

    }
}
