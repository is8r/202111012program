using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentScript : MonoBehaviour
{
    void Start()
    {
        //ここにコメントを記載します

        /*
         複数行のコメントが入ります。 
         複数行のコメントが入ります。
         複数行のコメントが入ります。
         複数行のコメントが入ります。
         複数行のコメントが入ります。
         */

        //TODO:
        //ここにはこういう処理を入れたい

        //FIXME:
        //ここにはバグがあるので後で直したい

        Action(10);
    }

    /// <summary>
    /// Actionメソッドは〇〇の処理を実行します。
    /// </summary>
    /// <param name="score">点数を追加する値</param>
    void Action(int score)
    {
        
    }
}
