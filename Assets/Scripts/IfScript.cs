using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfScript : MonoBehaviour
{
    public int age = 20;

    void Start()
    {
        // 数値での条件分岐処理
        if (age == 20)
        {
            print("Aの処理");
        }
        else if (age > 20)
        {
            print("Bの処理");
        }
        else if (age > 100)
        {
            print("Cの処理");
        }
        else if (age > 1000)
        {
            print("Dの処理");
        }
        else
        {
            print("その他の処理");
        }

        //boolでの条件分岐
        bool isHangry = false;
        if (isHangry)
        {
            print("お腹がすいた！");
        }
        else
        {
            print("特に空いてない！");
        }

        //複数の条件分岐を併記する
        if((age > 20) && (isHangry))
        {
            print("Eの処理");
        }

        if ((age > 20) || (isHangry))
        {
            print("Fの処理");
        }
    }
}
