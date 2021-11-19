using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour
{
    int score = 0;

    void Start()
    {
        // 変数を宣言する
        string str = "文字列が入っています";

        print(str);

        str = "中身を入れ替えたよ";

        print(str);
    }

    void Update()
    {
        //マイフレームscoreがプラスされる
        score++;

        //スペースキーを押したらscoreの値を出力する
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print(score);
        }
    }
}
