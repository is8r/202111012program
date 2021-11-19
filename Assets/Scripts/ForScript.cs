using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForScript : MonoBehaviour
{
    void Start()
    {
        int count = 2;

        //繰り返し処理を行う
        for (int i = 1; i < 10; i++)
        {
            count *= i;

            if (count > 10000)
            {
                break;
            }
        }
        print(count);

        //配列を宣言する
        string[] array = new string[3];
        array[0] = "0番目";
        array[1] = "1番目";
        array[2] = "2番目";

        //配列の中身を繰り返し処理で調べる
        foreach (var item in array)
        {
            print(item);
        }
    }
}
