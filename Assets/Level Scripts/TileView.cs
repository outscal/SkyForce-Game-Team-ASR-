using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileView : MonoBehaviour
{
    private TileController tileController;
    private TileService tileService;
    private void Start()
    {
        tileService = GetComponent<TileService>();
    }
    internal void Enable()
    {
        gameObject.SetActive(true);
    }

    internal void Disable()
    {
        gameObject.SetActive(false);
    }
    public void Initalise(TileController tileController)
    {
        this.tileController = tileController;
    }
}
