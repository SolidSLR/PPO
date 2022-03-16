using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Old_Master : MonoBehaviour
{
    // Start is called before the first frame update
    private bool MilitaryAttackVillager(Military military, Villager villager){

        villager.BeingAttacked(military.Attack());

        return villager.CanDie();

    }
    // Start is called before the first frame update
    void Start()
    {

        /*List<Villager> redVillagers = new List<Villager>(){new Villager("Ire Mon")};

        //List<Military> redMilitary = new List<Military>(){new Military(Person.names[Random.Range(0, Person.names.Length)])};

        List<Villager> blueVillagers = new List<Villager>();

        blueVillagers.Add(new Villager("Isa Ayu"));

        List<Military> blueMilitary = new List<Military>();

        List<Military> redMilitary = new List<Military>();

        for (int i=0; i<3; i++){

            blueMilitary.Add(new Military(Person.names[Random.Range(0, Person.names.Length)], (i+1)*10));

            redMilitary.Add(new Military(Person.names[Random.Range(0, Person.names.Length)], (i+1)*10));
        }

        /* Comenzan atacando os vermellos, despóis azuis. En cada ataque, seleccionase aleatoriamente un dos tres militares para atacar
        en cada equipo. Gaña o primeiro equipo que consiga matar ó aldeano do outro equipo.*/

        /*int randomAttack = Random.Range(0,2);

        int randomDefender = 0;

        if(randomAttack == 0){

            randomDefender = 1;
        }

        List<List<Villager>> villagers = new List<List<Villager>>();

        villagers.Add(blueVillagers);

        villagers.Add(redVillagers);

        List<List<Military>> militaries = new List<List<Military>>();

        militaries.Add(blueMilitary);

        militaries.Add(redMilitary);

        while(!blueVillagers[0].CanDie() || !redVillagers[0].CanDie()){

                //blueVillagers[0].BeingAttacked(redMilitary[Random.Range(0,redMilitary.Count)].Attack());

                if(MilitaryAttackVillager(militaries[randomAttack][Random.Range(0,3)], villagers[randomDefender][0])){

                    blueVillagers[0] = null;

                    Debug.Log("Hay una victoria. ¿De quién? No se sabe.");

                    break;
                }

                randomAttack = randomDefender;

                if(randomAttack == 0){

                    randomDefender = 1;
                } else {

                    randomDefender = 0;
                }

                //redVillagers[0].BeingAttacked(blueMilitary[Random.Range(0,blueMilitary.Count)].Attack());
                
                /*if(MilitaryAttackVillager(redMilitary[Random.Range(0,redMilitary.Count)], blueVillagers[0])){

                    redVillagers[0] = null;

                    Debug.Log("Oh no, las cosas no han cambiado para nada");

                    break;
                }*/
        

        /*while(!blueVillagers[0].CanDie() || !redVillagers[0].CanDie()){

            if(randomAttack == 0){

                blueVillagers[0].BeingAttacked(redMilitary[Random.Range(0,redMilitary.Count)].Attack());

                if(blueVillagers[0].CanDie()){

                    blueVillagers[0] = null;

                    Debug.Log("Los chavistas han alcanzado la victoria del proletariado");

                    break;
                }

                redVillagers[0].BeingAttacked(blueMilitary[Random.Range(0,blueMilitary.Count)].Attack());

                if(redVillagers[0].CanDie()){

                    redVillagers[0] = null;

                    Debug.Log("Oh no, las cosas no han cambiado para nada");

                    break;
                }

            } else if(randomAttack == 1){

                redVillagers[0].BeingAttacked(blueMilitary[Random.Range(0,blueMilitary.Count)].Attack());

                if(redVillagers[0].CanDie()){

                    redVillagers[0] = null;

                    Debug.Log("Los chavistas han alcanzado la victoria del proletariado");

                    break;
                }

                blueVillagers[0].BeingAttacked(redMilitary[Random.Range(0,redMilitary.Count)].Attack());

                if(blueVillagers[0].CanDie()){

                    blueVillagers[0] = null;

                    Debug.Log("Oh no, las cosas no han cambiado para nada");

                    break;
                }
            }
        }*/

        /*Villager aldeano = new Villager("Karim");

        Military militar = new Military("Adolfito");

        Debug.Log(aldeano.BeingAttacked(militar.Attack()));

        Debug.Log(aldeano.CanDie());

        Debug.Log(militar.ToString());

        Debug.Log(aldeano.ToString());*/


        /* Mi versión:
        
        Villager aldeano = new Villager(Person.names[Random.Range(0, Person.names.Length)], 50);

        Military militar = new Military(Person.names[Random.Range(0, Person.names.Length)], 50, 10);

        Debug.Log("Soy un militar y ataco con "+militar.Attack()+" de daño y la vida restante del aldeano será");*/

        /*List<Villager> villagers = new List<Villager>();


        for(int i = 0; i<10; i++){

            aldeano = new Villager(Person.names[Random.Range(0, Person.names.Length)]);

            villagers.Add(aldeano);
        }

        foreach(Villager villager in villagers){

            Debug.Log("Soy el aldeano "+villager.MyName()+", soy el número "+(villagers.IndexOf(villager)+1)+" y me van a poner a trabajar.");
            Debug.Log(villager.Work());
        }

        Debug.Log(eu.Work());

        Debug.Log(eu.GroundMovement());

        Debug.Log(eu.BeingAttacked(5));

        Debug.Log(eu.Spawn());

        Debug.Log(eu.Die());*/

        /* Crear dos equipos, 5 aldeanos y 5 militares por equipo. Se realizan ataques aleatorios de soldados aleatorios a aldeanos aleatorios*/

        /*
        
        Create 2 villagers, 1 building, 1 warrior, 1 archer per team. Warrior attack power's 10. Archer attack power's 5. Choose one of them and make it attack
        to one of the people from the other team. If a unit dies, shall be notified, and if it's attacked, turn passes. Print who wins.

        Crear dos listas, azul y roja. Contienen todas la unidades de cada equipo. Crear clases guerrero y arquero. Crea dos aldeanos, un edificio, un guerrero
        y un arquero por equipo. El guerrero ataca 10 y el arquero 5.
        Empieza un equipo aleatorio y uno de los militares (random) hace el primer ataque. Ataca a una de las cinco unidades aleatoriamente.
        Si la unidad está muerta, debe notificarse, pero si es atacada, se pasa el turno. Imprime por pantalla quién gana.

        */
    }
}
