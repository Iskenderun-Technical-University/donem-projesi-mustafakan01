using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Piker : MonoBehaviour
{
    public static Piker instance;

    public GameObject maincube;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        this.transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {        
        other.GetComponent<ICollectable>()?.Collect();
        other.GetComponent<ICoinable>()?.Coins();
        other.GetComponent<IFinishable>()?.GameFinish();
    }
   
}