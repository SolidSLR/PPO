using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableChar : Unidades {

    private int cost;

    private List<Terrain> standable_terrain;
    
}

enum Terrain{

    Ground,
    Water,
    Mountain,
    Forest
}
