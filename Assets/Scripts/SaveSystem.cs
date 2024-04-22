using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem 
{
    public static void SaveBoard (Board board) 
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/boardData.dt";
        FileStream stream = new FileStream(path, FileMode.Create);

        BoardData data = new BoardData(board.GetTiles());

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static BoardData LoadBoard () 
    {
        string path = Application.persistentDataPath + "/boardData.dt";
        if(File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open); 

            BoardData data = formatter.Deserialize(stream) as BoardData;
            stream.Close();

            return data;
        } else {
            Debug.LogError("Save file not found" + path);
            return null;
        }
    }
}

