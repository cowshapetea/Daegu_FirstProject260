using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    // �迭 ������ ����(�ݵ�� �� ������ ����)
    int[] ages = new int[10];



    // Start is called before the first frame update
    void Start()
    {
        //ages[0] = 20;
        //ages[1] = 50;
        //ages[8] = 15;
        //ages[1] = 30;

        //print(ages[1]);

        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = i * 10;
        }

        for (int i = 0; i < ages.Length; i++)
        {
            print("index::" + i.ToString() + ", value:" + ages[i].ToString());
        }

        //ages �迭 �������� 50�� �Ѵ� ���� ������ ������.

        int count = 0;

        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] > 50)
            {
                count++;
            }
        }

        print("ages �迭���� 50�� �Ѵ� �ε����� �� ���� : " + count.ToString());




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
