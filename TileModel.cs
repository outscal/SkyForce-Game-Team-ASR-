using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileModel 
{

    private TileScriptableObject tileScriptableObject;
    // Start is called before the first frame update

    public TileModel(TileScriptableObject tileScriptableObject)
    {
        this.tileScriptableObject = tileScriptableObject;
        TileName = tileScriptableObject.TileName;
    }

    public TileModel(string name)
    {
        TileName = name;
    }

    public string TileName { get; } 
}
