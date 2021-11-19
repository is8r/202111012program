using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//サンジがランダムでいろいろなセリフを話すクラス
public class SnajiScript : MonoBehaviour
{
    //メッセージを表示するテキストエリア
    public Text message;

    //ランダムでテキストを入れ替えるメソッド
    public void ChangeMessage()
    {
        //出力したいセリフの入れ物を宣言
        string comment;

        //ランダムでテキストを作成してcommentに代入する
        switch (Random.Range(0, 10))
        {
            case 0:
                comment = "逃げちゃだめだ";
                break;
            case 1:
                comment = "笑えばいいと思うよ";
                break;
            case 2:
                comment = "僕だって乗りたくてのってるわけじゃないのに";
                break;
            case 3:
                comment = "槍があれば全部やりなおせる！";
                break;
            case 4:
                comment = "坊やだからさ";
                break;
            default:
                comment = "ナミさ〜ん";
                break;
        }

        //commentの値をmessageのテキストエリアに挿入する
        message.text = comment;
    }
}
