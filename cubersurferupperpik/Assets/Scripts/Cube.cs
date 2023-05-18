using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour,ICollectable,IDecreaseable
{
    private bool hasgathered;
    
    private float index;
    public Rigidbody r_Rigidbody { private get; set; }
    void Start()
    {
        hasgathered = true;
    }
    public void Collect()
    {
        gameObject.transform.parent = Piker.instance.maincube.transform;
        r_Rigidbody = gameObject.AddComponent<Rigidbody>();
        r_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;

        if (hasgathered == true)
        {
            if (transform.parent != null)
            {
               transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    public void Decreas()
    {
        transform.parent = null;
        GetComponent<Cube>().enabled = false;
    }
    
}