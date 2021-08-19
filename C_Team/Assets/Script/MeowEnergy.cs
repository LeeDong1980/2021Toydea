using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeowEnergy : MonoBehaviour
{
    public float maxEnergy;
    private float _energy;
    public float energy
    {
        get { return _energy; }
        set { _energy = value;
            _energy = (_energy > 100f) ? 100f : (_energy < 0f) ? 0f : _energy;
              ApplyEnergy(); }
    }

    private Slider slider;
    public float DecreaseByTimeRatio;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.maxValue = maxEnergy;
        energy = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseByTime();
    }

    public void DecreaseByTime()
    {
        energy -= Time.deltaTime * DecreaseByTimeRatio;
    }
    public void Change(float amount)
    {
        energy += amount;
    }
    
    public void ApplyEnergy()
    {
        slider.value = energy;
    }
}
