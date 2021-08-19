using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonInput : MonoBehaviour
{
    public Charge chargeScript;
    public AttackArea attackArea;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = GameObject.Find("AttackArea").GetComponent<AttackArea>();
        chargeScript.ReleaseCharge();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            chargeScript.IncreaseCharge();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Attack();
            chargeScript.ReleaseCharge();
        }
    }

    

    private void Attack()
    {
        if (!attackArea)
        {
            Debug.LogError("Missing AttackArea!");
        }
        //Apply charge attck
        attackArea.ApplyAttack(chargeScript.CheckCharged());
    }
    
}
