using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�v�f���T�̔z�������������
        int[] array = new int[5];

        //�z��̊e�v�f�ɒl��������
        array[0] = 10;
        array[1] = 20;
        array[2] = 15;
        array[3] = 25;
        array[4] = 30;

        //�z��̊e�v�f�̒l�����Ԃɕ\������
        for (int a = 0; a < 5; a++)

        {
            Debug.Log(array[a]);
        }

        //�z��̊e�v�f�̒l���t���ɕ\������
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
