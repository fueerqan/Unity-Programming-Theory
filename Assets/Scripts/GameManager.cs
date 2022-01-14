using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerData playerData;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadSavedData();
    }

    public void SaveUserName(string username)
    {
        playerData.username = username;
        UpdateSavedData();
    }

    public void UpdateBestScore(int newScore)
    {
        if (playerData.bestScore < newScore)
        {
            playerData.bestScore = newScore;
            UpdateSavedData();
        }
    }

    private void UpdateSavedData()
    {
        string json = JsonUtility.ToJson(playerData);
        File.WriteAllText($"{Application.persistentDataPath}/savefile.json", json);
    }

    public void LoadSavedData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            playerData = JsonUtility.FromJson<PlayerData>(json);
        }
    }

    [System.Serializable]
    public class PlayerData
    {
        public string username;
        public int bestScore;
    }
}
