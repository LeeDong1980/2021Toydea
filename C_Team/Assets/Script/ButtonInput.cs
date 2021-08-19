using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonInput : MonoBehaviour
{
    public MeowEnergy meowEnergy;
    public Charge chargeScript;
    public AttackArea attackArea;

    public float missAttackCost = 10f;
    public 
    // Start is called before the first frame update
    void Start()
    {
        attackArea = GameObject.Find("AttackArea").GetComponent<AttackArea>();
        chargeScript.ReleaseCharge();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (attackArea.item && attackArea.item is PressAttackItem)
            {
                PressAttackItem temp = attackArea.item.GetComponent<PressAttackItem>();
                temp.EnterFreezeTime();
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            chargeScript.IncreaseCharge();
            if(attackArea.item && attackArea.item is PressAttackItem)
            {
                PressAttackItem temp = attackArea.item.GetComponent<PressAttackItem>();
                temp.UpdateFreezeTime();
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Attack();
            chargeScript.ReleaseCharge();
            if (attackArea.item && attackArea.item is PressAttackItem)
            {
                PressAttackItem temp = attackArea.item.GetComponent<PressAttackItem>();
                temp.ExitFreezeTime();
            }
        }
    }

    

    private void Attack()
    {
        if (!attackArea)
        {
            Debug.LogError("Missing AttackArea!");
            return;
        }
        if (!attackArea.item)
        {
            meowEnergy.Change(-missAttackCost);
        }
        //Apply charge attck
        attackArea.ApplyAttack(chargeScript.CheckCharged());
    }
    
    
}
