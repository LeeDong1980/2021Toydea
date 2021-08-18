using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    public float chargeValue;
    public float chargeRatio;
    public float chargeThreshold;

    public AttackArea attackArea;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = GameObject.Find("AttackArea").GetComponent<AttackArea>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Charge();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Attack();
            ReleaseCharge();
        }
    }

    private void Charge()
    {
        chargeValue += chargeRatio;
    }
    private void ReleaseCharge()
    {
        chargeValue = 0;
    }

    private void Attack()
    {
        if (!attackArea)
        {
            Debug.LogError("Missing AttackArea!");
        }
        if(chargeValue < chargeThreshold)
        {
            //Apply normal attack
            attackArea.ApplyAttack(false);
        }
        else
        {
            //Apply charge attck
            attackArea.ApplyAttack(true);
        }
    }
}
