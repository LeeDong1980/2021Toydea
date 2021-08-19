using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAttackItem : Item
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
                attackArea.ClearCurrentItem();
                gameObject.SetActive(false);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Init()
    {
        base.Init();
        hp = maxHp;
    }
    public override void Hit(float damage)
    {
        base.Hit(damage);
        hp -= damage;
    }
    public override void Hurt()
    {
        base.Hurt();
    }
    public override void Recycle()
    {
        base.Recycle();
    }
}
