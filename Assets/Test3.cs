using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
    }

}

public class Test3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Boss2 lastboss = new Boss2();
        lastboss.Attack();
        lastboss.Defence(3);
        for(int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }

        Boss2 midboss = new Boss2();
        midboss.Attack();
        midboss.Defence(2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
