using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float hp;
    public bool canHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Hit()
    {
        if (!canHit) return;
        Debug.Log("Hit!!!");
    }
    public virtual void Hurt()
    {
        Debug.Log("Hurt OAO");
    }
    public virtual void Recycle()
    {
        Debug.Log("Recycle -_-");
    }
}
