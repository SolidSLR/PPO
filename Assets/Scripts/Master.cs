using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{

    private bool MilitaryAttackVillager(Military military, Villager villager){

        villager.BeingAttacked(military.Attack());

        return villager.CanDie();

    }
    // Start is called before the first frame update
    void Start()
    {
        /*
        
        Create 2 villagers, 1 building, 1 warrior, 1 archer per team. Warrior attack power's 10. Archer attack power's 5. Choose one of them and make it attack
        to one of the people from the other team. If a unit dies, shall be notified, and if it's attacked, turn passes. Print who wins.

        Crear dos listas, azul y roja. Contienen todas la unidades de cada equipo. Crear clases guerrero y arquero. Crea dos aldeanos, un edificio, un guerrero
        y un arquero por equipo. El guerrero ataca 10 y el arquero 5.
        Empieza un equipo aleatorio y uno de los militares (random) hace el primer ataque. Ataca a una de las cinco unidades aleatoriamente.
        Si la unidad está muerta, debe notificarse, pero si es atacada, se pasa el turno. Imprime por pantalla quién gana.

        */

        List<Unidades> redTeam = new List<Unidades>();

        List<Unidades> blueTeam = new List<Unidades>();

        bool blueDeadTeam = false;

        bool redDeadTeam = false;

        int randomTeam = Random.Range(0,2);

        int randomhitter;

        int randomhitted;

        for (int i = 0; i < 2; i++){

            redTeam.Add(new Villager("Red villager "+Person.names[Random.Range(0, Person.names.Length)]));

            blueTeam.Add(new Villager(Person.names[Random.Range(0, Person.names.Length)]));
        
        }

        redTeam.Add(new Building());
        blueTeam.Add(new Building());

        redTeam.Add(new Archer(Person.names[Random.Range(0, Person.names.Length)], 5));
        redTeam.Add(new Warrior(Person.names[Random.Range(0, Person.names.Length)]));

        blueTeam.Add(new Archer(Person.names[Random.Range(0, Person.names.Length)], 5));
        blueTeam.Add(new Warrior(Person.names[Random.Range(0, Person.names.Length)]));

        if(randomTeam == 0){

            randomhitter = Random.Range(3,5);

            randomhitted = Random.Range(0,5);

            Debug.Log(blueTeam[randomhitted].BeingAttacked(((Military)redTeam[randomhitter]).Attack()));            

        }

        while(true){

            if((redTeam[3].CanDie() && redTeam[4].CanDie()) || (blueTeam[3].CanDie() && blueTeam[4].CanDie())){

                break;
            }

            for(int i = 0; i <redTeam.Count; i++){

                if(!redTeam[i].CanDie()){

                    redDeadTeam = false;
                } else {
                    redDeadTeam = true;
                }
            }

            if(redDeadTeam){

                break;
            }

            for(int i = 0; i <blueTeam.Count; i++){

                if(!blueTeam[i].CanDie()){

                    blueDeadTeam = false;
                } else {
                    blueDeadTeam = true;
                }
            }

            if(blueDeadTeam){

                break;
            }

            randomhitter = Random.Range(3,5);

            randomhitted = Random.Range(0,5);

            randomTeam = Random.Range(0,2);

            if(randomTeam == 0){

                if(redTeam[randomhitted].CanDie()){

                    Debug.Log("Déjalo, ya está muerto");

                } else{

                    Debug.Log(redTeam[randomhitted].BeingAttacked(((Military)blueTeam[randomhitter]).Attack())); 
            
                }
            } else {

                if(blueTeam[randomhitted].CanDie()){

                    Debug.Log("Déjalo, ya está muerto");

                } else{

                    Debug.Log(blueTeam[randomhitted].BeingAttacked(((Military)redTeam[randomhitter]).Attack())); 
            
                } 
            }
        }            

        if(redDeadTeam || (redTeam[3].CanDie() && redTeam[4].CanDie())){

            Debug.Log("Pues parece que Putin ha obliterado a sus rivales"); 

        }

        if(blueDeadTeam  || (blueTeam[3].CanDie() && blueTeam[4].CanDie())){

            Debug.Log("El pueblo ucraniano está a salvo. ¡Hurra!");
        }
    }
}