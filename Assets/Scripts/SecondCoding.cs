using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int age1 = 15;
    public int age2 = 7;
    public bool isMan = true;
    public bool runState;
    public bool walkState;
    public int endCount = 100;
    public int printMax = 10;

    int sum = 0;
    int printCount = 0;
   

    

    // Start is called before the first frame update
    void Start()
    {
        #region ���ǹ�
        //���ǹ�
        // it(���ǽ�)
        // {
        // ������ �� �϶�, �ؾ��� ��
        // }
        // else if(���ǽ�)
        // {
        // �ι�° ���ǽ��� �� �϶�, �ؾ��� ��
        // }
        // else
        // {
        // �տ� �ִ� ��� ���ǵ��� �� �������� ���� ��, �ؾ��� ��
        // }
        #endregion ���ǹ�

        #region Example 1

        //if(age1 == age2)
        //{
        //    print("age1�� age2�� ���̰� �����ϴ�");
        //}

        //if(age1 > age2)
        //{
        //    print("age1�� age2���� ���̰� �����ϴ�");
        //}
        //if (age1 < age2)
        //{
        //    print("age1�� age2���� ���̰� �����ϴ�");
        //}

        //if(age1 != age2)
        //{
        //    print("age1�� age2�� ���̰� ���� �ٸ��ϴ�");

        //}

        // age1�� ���̸� �������� 10����� 40����� ������� �ش��ϴ����� ����Ѵ�.
        // ��) "age1�� 30�� �Դϴ�."

        //if (age1 < 20)
        //{
        //    print("age1�� 10�� �Դϴ�.");

        //}
        //else if (age1 < 30)
        //{
        //    print("age1�� 20�� �Դϴ�.");

        //}
        //else if (age1 < 40)
        //{
        //    print("age1�� 30�� �Դϴ�.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1�� 40�� �Դϴ�.");

        //}
        //else
        //{ print("age1�� ���̴� 50�� �̻��Դϴ�."); }





        //if(age1 >= 20)
        //{
        //    print("age1�� ���̴� 20�� �̻��Դϴ�");

        //}

        //else
        //{ print("age1�� ���̴� 20�� �̸��Դϴ�."); }

        #endregion Example 1

        #region Example 2

        // 1. and ����
        // ����, ������ �����̰� ���̰� 20�� �̻��� ���
        //"���� �����Դϴ�"��� ����Ѵ�.

        //if(isMan == false && age1 >= 20)
        //{ print("���� �����Դϴ�."); }

        //else { print("�̼������̰ų�, �����Դϴ�."); }

        // 2. or ����
        // ����, �����̴� ����� "�̵� ���Դϴ�."��� ����ϰ�,
        // �׷��� ������, "������ �����Դϴ�." ��� ����Ѵ�.

        //if (runState == true || walkState == true)

        //{ print("�̵� ���Դϴ�."); }

        //else { print("������ �����Դϴ�."); }

        // bool ������ ���ǹ��� �������� �־��� �� ���� ���
        //if(runState == true)
        //�� �Ʒ��� ����
        //if(runState)

        //if(runState == false)
        //�� �Ʒ��� ����
        //if(!runState)



        #endregion Example 2


        #region �ݺ���
        // �ݸ�
        // for (���� ���� ���� �� �ʱ�ȭ ; ���� ���ǽ�; ������ )
        // {
        // �ݺ��ؼ� ������ ����
        // }

        // 1���� 10���� ��� ������ ����Ѵ�.

        // for(int i = 0; i < 20; i = i + 1)
        // { print(i + 1);  }

        // 1���� 100���� �� ���� ���� sum �̶�� ������ �����ؼ� ����Ѵ�.

        //for (int i = 0; i < endCount; i = i + 1)
        //{ sum = sum + i + 1; }    
        //print(sum);

        for (int i = 0; i < endCount; i = i + 1)
        { sum = sum + i + 1; }
        print("���Ͻô� �հ� ���� " + sum.ToString() + "�Դϴ�.");

        // �� �Ʒ� ��(��) �� ����

        //for (int i = 0; i < 100; i = i + 1)
        //{ sum = sum + i + 1; }    
        //print(sum);

        #endregion �ݺ���

        #region ������
        // ������
        // int num = 0;

        // num = num + 1;
        // num += 1;
        // num ++;
        // num --;
        // num -= 1;
        // B��� ��ȭ C��� ��ȭ C++(1����) ��ȭ C#(++++, 2?����)

        #endregion ������

        #region ����1

        // ����) 1���� 20���� �߿� ¦���� ����Ѵ�.
        // 1. 20�� �ݺ��Ѵ�.
        //for (int i = 0; i < 20; i++)
        //{
        //    int number = i + 1;
        //    // 2. ���� number�� ���� 2�� ���� �������� 0�̶��
        //    if (number % 2 == 0)
        //    // 3. �� number�� ����Ѵ�.
        //    { print(number); }

        #endregion ����1

        #region ����2

        // ����) 0���� endCount ������ ¦���� ����Ѵ�. �׷��� ��µ� ¦���� ���� 10���� �����ϸ� �ݺ��� �����Ѵ�.

        // 1. 0���� endCount ������ �ݺ��Ѵ�.
        for (int i = 0; i < endCount; i++)
        {
            // 2. �����Ǵ� ������ 2�� ���� �������� 0�� ��쿡�� ����Ѵ�.
            if (i % 2 == 0)
            {
                print(i);
                // 3. printCount ������ ����� Ƚ���� ������Ų��.
                printCount++;
                // ���� printCount�� ���� 10�� �����ϸ� �ݺ��� �����Ѵ�.
                if (printCount >= printMax)

                { break; }

                //for (int endCount = 0; endCount < 100; endCount++)
                //{ int number = endCount + 1;
                //    if (number % 2 == 0) break = 10);
                //    { print(number); } }



            }



        }
        #endregion ����2


        #region for if ��ø�ϱ�

        // for ���� if ���� ���� ��ø�ؼ� ����� �� �ִ�.

        // ���� ������ �����̸鼭, ���̰� 20�� �̻��� ���
        // if(isMan && age1 >= 20)
        //{}
        //else{}
        //if (isMan)
        //{  if (age1 >= 20){} else{} }

        #endregion for if ��ø

        #region ������

        //for (int i = 2; i < 10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    { print(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString()); }

        #endregion ������

        #region �� �Ƕ�̵�

        // *
        // **
        // ***
        // ****
        // *****

        // < Ǯ�� 1�� >
        //string star = "";
        //for (int i = 0; i < 5; i++)
        //{ star += "*";
        //    print(star); }

        //// < Ǯ�� 2�� >
        //string star = "";
        //for (int i = 0; i < 5; i++)
        //{ 
        //    for (int j = 0; j < i + 1; j++)
        //    { 
        //        star += "*";
        //    }
        //    star += "\n";
        //}
        ////star = "*\n**\n***\n****\n*****"
        //print(star);

        #endregion �� �Ƕ�̵�

        #region ���Ƿ� ���� �����

        ////print("hello world");
        //Debug.Log("Hello World");
        //Debug.LogWarning("Hello World");
        //Debug.LogError("Hello World");

        #endregion ���Ƿ� ���� �����

    }



















}
