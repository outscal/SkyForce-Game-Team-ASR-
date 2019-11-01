using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController 
{
    public Vector3 currentPosition;
    public TileController(TileModel tileModel, TileView tilePrefab)
    {
        TileModel = tileModel;
        TileView = Object.Instantiate(tilePrefab);
        TileView.Initalise(this);
        //Debug.Log("tile view created", TileView);
    }
    public void SetPosition()
    {
        //currentPosition = TileView.transform.position + new Vector3(0,100f,0f);
    }

    public void Disable()
    {
        TileView.transform.position += new Vector3(0f,50f,0f);
        TileView.Disable();
    }

    public void Enable()
    {
        TileView.Enable();
    }

    public TileModel TileModel { get; }
    public TileView TileView { get; }
}
