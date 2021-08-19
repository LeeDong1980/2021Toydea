using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charge : MonoBehaviour
{
    private Slider slider;
    public float _chargeValue;
    public float chargeValue
    {
        get { return _chargeValue; }
        set
        {
            _chargeValue = value;
            ApplyChargeValue();
        }
    }
    public float maxChargeValue;
    public float chargeRatio;
    public float chargeThreshold;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = maxChargeValue;
        ReleaseCharge();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCharge()
    {
        chargeValue += chargeRatio;
    }
    public void ReleaseCharge()
    {
        chargeValue = 0;
    }

    private void ApplyChargeValue()
    {
        slider.value = chargeValue;
    }
    public bool CheckCharged()
    {
        if (chargeValue >= chargeThreshold)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
