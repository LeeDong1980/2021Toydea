using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public Item item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyAttack(bool isCharge)
    {
        if (!item) return;
        if (isCharge)
        {
            Debug.Log("Charge Attack!!!");
            item.Hit();
        }
        else
        {
            Debug.Log("Normal Attack");
            item.Hit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        item = other.GetComponent<Item>();
    }
}
