using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServicePoolTiles : ServicePool<TileController>
{
    private TileView tilePrefab;
    private TileModel tileModel;

    public TileController GetTile(TileModel tileModel, TileView tilePrefab)
    {
        this.tileModel = tileModel;
        this.tilePrefab = tilePrefab;
        //Debug.Log("1");
        return GetObject();
    }

    protected override TileController CreateObject()
    {
        TileController tileController = new TileController(tileModel, tilePrefab);
        return tileController;
    }
}
