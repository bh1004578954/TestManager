using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    delegate void NumberChanger(int num);
    public int a=0;
    NumberChanger nc;
    public void MultNum(int num)
    {
        a *= num;
        Debug.Log(a);
    }
    public void AddNum(int num)
    {
        a += num;
        Debug.Log(a);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            nc = delegate (int num)
            {
                a += num;
                Debug.Log(a);
            };
            nc(5);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            nc = new NumberChanger(AddNum);
            nc(5);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            nc = new NumberChanger(MultNum);
            nc(5);
        }
    }
}
