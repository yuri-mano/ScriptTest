using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //要素数５の配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 15;
        array[3] = 25;
        array[4] = 30;

        //配列の各要素の値を順番に表示する
        for (int a = 0; a < 5; a++)

        {
            Debug.Log(array[a]);
        }

        //配列の各要素の値を逆順に表示する
        for (int b = 4; b >= 0; b--)

        {
            Debug.Log(array[b]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
