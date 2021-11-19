using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example1 : MonoBehaviour
{
    void Start()
    {
        //問題1: 数字を1から100まで足した合計の数を計算しよう！
        int n = 0;
        for (int i = 1; i < 101; i++)
        {
            n += i;
        }
        print(n);

        //問題2: 3の倍数だけを抽出して合計した値を計算しよう

    }
}
