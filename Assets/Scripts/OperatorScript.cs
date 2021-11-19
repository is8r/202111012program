using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorScript : MonoBehaviour
{
    void Start()
    {
        //変数を宣言する
        int i = 1000;

        i = i + 1;

        print(i);

        i++;

        print(i);

        i--;

        print(i);

        i /= 10;

        print(i);

        i %= 3;

        print(i);
    }
}
