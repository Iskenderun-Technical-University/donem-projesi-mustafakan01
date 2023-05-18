using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour,IFinishable
{
    void Final()
    {  
        LevelManager.instance.SaveGame();
        LevelManager.instance.DestroyLevel();
    }
 
    
   public void GameFinish()
    {
        Final();
    }
}
