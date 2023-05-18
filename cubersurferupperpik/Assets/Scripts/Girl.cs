using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    public static Girl girl;

    [SerializeField] private Animator anim;
    public int life { get; set; }

    void Awake()
    {
        if (girl == null)
        {
            girl = this;
        }
    }

     void Start()
    {
        life = 1;
        anim = GetComponent<Animator>();
    
    }

    void Update()
    {
        if (life != 1)
        {
            anim.SetInteger("life", 0);
           
        }
    }
    
}
