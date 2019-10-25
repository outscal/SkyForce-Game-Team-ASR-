using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileService : MonoBehaviour
{
    public TileView tileView;
    private ServicePoolTiles servicePoolTiles;
    public TileScriptableObjectList tileList;
    public Transform parentForTile;
    private Transform playerTransform;

    private int amnTilesOnScreen = 4;
    private float spawnPos = 0.1f;
    private float tileLength = 10f;

    private void Start()
    {
        servicePoolTiles = GetComponent<ServicePoolTiles>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        
        if (playerTransform.position.y > (spawnPos - amnTilesOnScreen * tileLength))
        {
            SpawnTiles();
        }
    }

    void SpawnTiles()
    {
        TileController tileController = CreateNewTile(0);
        StartCoroutine(ReturnTile(tileController));
    }

    IEnumerator ReturnTile(TileController tileController)
    {
        yield return new WaitForSeconds(12f);
        Debug.Log("Returning");

        tileController.Disable();
        servicePoolTiles.ReturnObject(tileController);
    }

    private TileController CreateNewTile(int index)
    {
        TileScriptableObject tileScriptableObject = tileList.tiles[index];

        tileView.transform.position = Vector3.up * spawnPos;
        spawnPos += tileLength;
        Debug.Log("Creating Tank with name: " + tileScriptableObject.TileName);

        TileModel model = new TileModel(tileScriptableObject);
        TileController tile = servicePoolTiles.GetTile(model, tileView);

        tile.Enable();
        return tile;
    }
}
