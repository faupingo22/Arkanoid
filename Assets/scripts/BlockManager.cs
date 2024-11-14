using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject[] blocks;  
    public LevelManager levelManager;  

    void Start()
    {
        
        blocks = GameObject.FindGameObjectsWithTag("Block");
    }

    void Update()
    {
        if (AllBlocksDestroyed())  
        {
            levelManager.CompleteLevel(); 
        }
    }

    
    bool AllBlocksDestroyed()
    {
        foreach (var block in blocks)
        {
            if (block != null)  
                return false;
        }
        return true;  
    }
}
