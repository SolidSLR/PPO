using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : PlayableChar {

    private List<Buildings> type;

    public Building(){

        Debug.Log("Me han levantado con mucho esfuerzo, Edificio-kun está a su servicio");
    }
}

enum Buildings{

    House,

    Farm,

    MilitaryBase,

    Castel,

    Church,
}