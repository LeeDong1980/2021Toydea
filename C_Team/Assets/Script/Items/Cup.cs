using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : Item
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Hit()
    {
        base.Hit();
        Destroy(gameObject);
    }
    public override void Hurt()
    {
        base.Hurt();
    }
    public override void Recycle()
    {
        base.Recycle();
    }
}
