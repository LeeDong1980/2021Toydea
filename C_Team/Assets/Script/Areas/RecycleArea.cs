using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponent<Item>();
        if (item)
        {
            item.Recycle();
        }
    }
}
