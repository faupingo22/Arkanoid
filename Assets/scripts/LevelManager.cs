using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public string nextLevelName;  

    
    public void CompleteLevel()
    {
        LoadNextLevel();
    }

    
    private void LoadNextLevel()
    {
        
        SceneManager.LoadScene("level2");
    }
}
