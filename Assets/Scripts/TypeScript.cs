using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeScript : MonoBehaviour
{
    void Start()
    {
        //文字列
        string str = "文字";//"ABC", "1,000.00"

        //整数
        int i = 0;//-1, 0, 1, 100

        //小数
        float f = 0.1f;//0.01f, 0.000001f;

        //bool
        bool b = true;//true, false

        print(b);
        print(b.GetType());
    }
}
