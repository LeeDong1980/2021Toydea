using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboAttackItem : Item
{
    public float maxHp;
    [SerializeField]

    private float _hp;
    public float hp
    {
        get { return _hp; }
        set
        {
            _hp = value;
            if (_hp <= 0f)
            {
                //Debug.Log("現在血量" + _hp);
                canHit = false;
                ExitFreezeTime(true);
                attackArea.ClearCurrentItem();
                gameObject.SetActive(false);
            }
        }
    }
    public float freezeTime = 3f;
    public bool isFreeze;
    private float timer = 0f;
    private ItemPath itemPath;

    // Start is called before the first frame update
    void Start()
    {
        Init();
        hp = maxHp;
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
    }
    public override void Hit(float damage)
    {
        base.Hit(damage);
        hp -= damage;
        EnterFreezeTime();
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
        //Debug.Log("EnterFreezeTime~");
        isFreeze = true;
        timer = 0;

        itemPath.Freeze();
    }
    public void UpdateFreezeTime()
    {
        if (!isFreeze) return;
        timer += Time.deltaTime;
        //Debug.Log("UpdateFreezeTime......." + "Timer: " + timer);
        
        if(hp <= 0)
        {
            ExitFreezeTime(true);
            return;
        }
        if(timer >= freezeTime)
        {
            ExitFreezeTime(false);
            return;
        }

    }
    public void ExitFreezeTime(bool isSuccessful)
    {
        if (!isFreeze) return;
        //Debug.Log("ExitFreezeTime 0.0");
        if (isSuccessful)
        {
            //add point
            Debug.Log("Add point");
        }
        else
        {
            //lose energy
            Debug.Log("Lose energy");
        }

        itemPath.Resume();
    }
}
