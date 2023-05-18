using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour,IGameOverable
{
    public GameObject gameOver;
    public void Over()
    {
        Debug.Log("Game Over");
        gameOver.SetActive(true);
        Move.move.enabled = false;
        Girl.girl.life = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<IDecreaseable>()?.Decreas();
    
    }   

}
