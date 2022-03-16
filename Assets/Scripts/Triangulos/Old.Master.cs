using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMaster : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        /*List<float> areas2 = new List<float>();

        float[] areas = new float[10000];

        Triangulo t1 = new Triangulo(30f);

        Triangulo t2 = new Triangulo(45.3f);

        Debug.Log("Area de dos triángulos: "+t1.CalcularArea()+" · "+t2.CalcularArea());

        Debug.Log("Llamada a método estático "+Triangulo.CalcularAreaStatic(25.3f,12.6f));

        Debug.Log("Comprobación de triángulos creados: "+Triangulo.showCant());

        for (int i = 0; i<areas.Length; i++){

            float rand1 = Random.Range(0,2000);

            float rand2 = Random.Range(0,2000);

            float result = Triangulo.CalcularAreaStatic(rand1, rand2);

            areas[i] = result;
        }

        for(int j = 0; j < 10000; j++){

            float rand1 = Random.Range(0,2000);

            float rand2 = Random.Range(0,2000);

            float result = Triangulo.CalcularAreaStatic(rand1, rand2);

            areas2.Add(result);
        }

        for (int i = 0; i < areas2.Count; i++){
            Debug.Log("Área de triangulo "+(i+1)+": "+areas2[i]);
        }

        Debug.Log("Cantidad de areas calculadas: "+areas.Length);
        Debug.Log("Cantidad de areas2 calculadas: "+areas2.Count);*/

        List<Triangulo> triangulos = new List<Triangulo>();

        for(int i = 0; i < 5; i++){

            Triangulo t = new Triangulo(Random.Range(0,2000));

            triangulos.Add(t);

        }

        foreach(Triangulo item in triangulos){
            Debug.Log("Orden original: "+item.CalcularArea());
        }

        List<float> areasT = new List<float>();

        foreach(Triangulo item in triangulos){
            float area = item.CalcularArea();

            areasT.Add(area);
        }

        //Eliminar elemento con menor area e volver a imprimir

        areasT.Sort();
        areasT.Reverse();

        foreach(float item in areasT){
            Debug.Log("Reordenado: "+item);
        }

        areasT.RemoveAt(areasT.Count-1);

        foreach(float item in areasT){
            Debug.Log("Reordenado menos último: "+item);
        }

        //triangulos.RemoveAt(triangulos.Count-1);

        int indexMin = areasT.Count+1;
        float areaMin = 100000000;

        for(int i = 0; i < areasT.Count; i++){
            if(triangulos[i].CalcularArea() < areaMin){
                indexMin = i;
                areaMin = triangulos[i].CalcularArea();
            }
        }

        triangulos.RemoveAt(indexMin);
    }

}
