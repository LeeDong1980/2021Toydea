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
        if(item is PressAttackItem)
        {
            //Debug.Log("是魚魚哇");
        }
        else
        {
            if (isCharge)
            {
                //Debug.Log("Charge Attack!!!");
                item.Hit(20f);
            }
            else
            {
                //Debug.Log("Normal Attack");
                item.Hit(10f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        item = other.GetComponent<Item>();
        item.canHit = true;
    }
    private void OnTriggerExit(Collider other)
    {
        item.canHit = false;
        ClearCurrentItem();
    }

    public void ClearCurrentItem()
    {
        item = null;
    }
}
