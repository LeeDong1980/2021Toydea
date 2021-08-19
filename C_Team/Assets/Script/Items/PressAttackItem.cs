using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressAttackItem : Item
{
    public bool isFreeze;
    //private float _process;
    private float process; 
    //{
    //    get { return _process; }
    //    set { _process = value;}
    //}
    public float processRatio = 1f;
    public float increaseFac = 0.1f;
    public ItemPath itemPath;
    
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFreezeTime();
    }
    public override void Init()
    {
        base.Init();
        itemPath = GameObject.Find("ItemPath").GetComponent<ItemPath>();
        
        slider = GameObject.Find("EatProcess").GetComponent<Slider>();
    }
    public override void Hit(float damage)
    {
        base.Hit(damage);
        //EnterFreezeTime();
    }
    public override void Hurt()
    {
        base.Hurt();
    }
    public override void Recycle()
    {
        base.Recycle();
    }

    public void EnterFreezeTime()
    {
        if (isFreeze) return;
        Debug.Log("EnterFreezeTime~");
        isFreeze = true;
        process = 0;
        //slider.gameObject.SetActive(true);
        itemPath.Freeze();
    }
    public void UpdateFreezeTime()
    {
        if (!isFreeze) return;
        process += processRatio;
        //Debug.Log("UpdateFreezeTime.......");
        float increastTemp = increaseFac;
        meowEnergy.Change(increastTemp);
        slider.value = process;

        Debug.Log("process:" + process);

        if (process > 100f)
        {
            ExitFreezeTime();
        }

    }
    public void ExitFreezeTime()
    {
        if (!isFreeze) return;
        //Debug.Log("ExitFreezeTime 0.0");

        slider.value = 0;
        itemPath.Resume();
        gameObject.SetActive(false);
        //slider.gameObject.SetActive(false);
    }
}
