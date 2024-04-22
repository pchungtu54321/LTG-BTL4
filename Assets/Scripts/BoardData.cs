using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomPlayer;

[System.Serializable]
public class BoardData
{
    public TileData[] tileDataArray;

    public BoardData(Tile[] tiles)
    {
        tileDataArray = new TileData[tiles.Length];
        for (int i = 0; i < tiles.Length; i++)
        {
            tileDataArray[i] = new TileData(tiles[i]);
        }
    }
}

[System.Serializable]
public class TileData
{
    public WorkerData _workerData = null;
    public int _towerPieceCount;

    public TileData (Tile tile) {
        if(tile.GetWorkerOnTile()) {
            _workerData = new WorkerData(tile.GetWorkerOnTile());
        }
        _towerPieceCount = tile.GetTowerPieceCount();
    }
}

[System.Serializable]
public class WorkerData
{
    public Worker.Gender _gender;
    public Worker.Colour _colour;

    public WorkerData (Worker worker) {
        _gender = worker.GetGender();
        _colour = worker.GetColour();
    }
}
