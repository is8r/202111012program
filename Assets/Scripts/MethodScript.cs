using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodScript : MonoBehaviour
{
    void Start()
    {
        //呼び出す側のメソッド
        //print("コンソール出力する");

        //メソッドを実行する
        //NewMethod();

        //
        //RandomDialogue();

        //引数付きのメソッドを実行する
        //VariableMethod(0);
        //VariableMethod(1);
        //VariableMethod(Random.Range(0,2));

        //3の倍数の時はシャアのセリフになるメソッドを実行する
        //CheckThreeDialogue(1);
        //CheckThreeDialogue(101);

        //ランダムな数値を返すメソッドを実行する
        //int randomCount = ReturnMethod();
        //print(randomCount);

        //問題3:「僕と契約して xxx になってよ」の xxx がランダムに帰ってくるメソッドを作ろう
        string dialog = ReturnWhatContract();
        print(dialog);
    }

    string ReturnWhatContract()
    {
        string job;
        switch (Random.Range(0, 5))
        {
            case 0:
                job = "戦闘員";
                break;
            case 1:
                job = "非常勤講師";
                break;
            case 2:
                job = "アルバイト";
                break;
            default:
                job = "魔法少女";
                break;
        }
        return $"僕と契約して{job}になってよ";
    }

    //ランダムな数値を返すメソッド
    int ReturnMethod()
    {
        int random = Random.Range(0, 5);
        return random * 100;
    }

    //3の倍数の時はシャアのセリフになるメソッド
    void CheckThreeDialogue(int i)
    {
        if((i % 3) == 0)
        {
            print("坊やだからさ");
        }
        else
        {
            print("こいつ、動くぞ！");
        }
    }

    void VariableMethod(int i)
    {
        if(i == 0)
        {
            print("こいつ、動くぞ！");
        }
        else if(i == 1)
        {
            print("親父にもぶたれた事ないのに！");
        }
        else
        {
            print("坊やだからさ");
        }
    }

    void RandomDialogue()
    {
        //ランダムな数字を作る
        int random = Random.Range(0, 5);

        //受け取った数字によって違うセリフを出力する
        if(random == 0)
        {
            print("こいつ、動くぞ！");
        }
        else if(random == 1)
        {
            print("親父にもぶたれた事ないのに！");
        }
        else
        {
            print("坊やだからさ");
        }
    }

    //呼び出される側のメソッド
    void NewMethod()
    {
        print("メソッドが呼び出されました");
    }
}
