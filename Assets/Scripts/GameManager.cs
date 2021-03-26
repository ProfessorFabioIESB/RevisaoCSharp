using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 0;
    public int score = 0;
    public int enemyCount = 20;

    public static GameManager Instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(Instance != null){
            Destroy(gameObject);
        }else{
            DontDestroyOnLoad(gameObject);
            Instance  = this;
        }
    }

    public void MostrarScore(){
        Debug.Log("Score: "+score);
    }

    public void SaveGame(int level){
        PlayerPrefs.SetInt("Lvl",level);
    }

    public void LoadGame(){
        int lvl = PlayerPrefs.GetInt("Lvl");
        Debug.Log("Scene: "+lvl);
    }
}
