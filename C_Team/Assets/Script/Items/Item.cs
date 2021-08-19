using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AttackArea attackArea;
    public MeowEnergy meowEnergy;
    public bool canHit;

    public virtual void Init()
    {
        canHit = false;
        meowEnergy = GameObject.Find("MeowEnergy").GetComponent<MeowEnergy>();
        attackArea = GameObject.Find("AttackArea").GetComponent<AttackArea>();
    }
    public virtual void Hit(float damage)
    {
        if (!canHit) return;
        //Debug.Log("Hit!!!");
    }
    public virtual void Hurt()
    {
        //Debug.Log("Hurt OAO");
        meowEnergy.Change(-20f);
    }
    public virtual void Recycle()
    {
        //Debug.Log("Recycle -_-");
        gameObject.SetActive(false);
    }
}
