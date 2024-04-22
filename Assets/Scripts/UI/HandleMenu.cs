// using UnityEngine;

// public class HandleMenu : MonoBehaviour
// {
//     public void loadScene(string SceneName)
//     {
//         //load scene
//         if (SceneName == "continue") {
//             UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(SaveSystem.savedSceneName).completed += OnConSceneLoaded;
//         } else UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(SceneName).completed += OnSceneLoaded;
//     }
//     private void OnSceneLoaded(AsyncOperation operation)
//     {
//         string sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
//         Santorini santorini = FindObjectOfType<Santorini>();
//         if (santorini != null)
//         {
//             santorini.initVariables();
//         }
//         else
//         {
//             Debug.LogWarning("Santorini object not found in the scene.");
//         }
//     }
//     private void OnConSceneLoaded(AsyncOperation operation) {
//         Santorini santorini = FindObjectOfType<Santorini>();
//         santorini.loadSaved();
//     }
// }
using UnityEngine;

public class HandleMenu : MonoBehaviour
{
    public void loadScene(string SceneName)
    {
        //load scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }
}

// public List<SetPlayer> getPLAYERS() {
//         return _PLAYERS;
//     }
//     public List<Player> getPlayers() {
//         return _players;
//     }
//     public Player getActivePlayer() {
//         return _activePlayer;
//     }
//     public Board getBoard() {
//         return _board;
//     }
    
//     public void SaveSantorini() {
//         SaveSystem.SaveSantorini(this);
//     }
//     public void LoadSantorini() {
//         SantoriniData data = SaveSystem.LoadSantorini();

//         _PLAYERS = data._PLAYERS;
//         _players = data._players;
//         _activePlayer = data._activePlayer;
//         _board = data._board;
//     }