using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    //������ ���� �����ϱ�
    public int numberInt1 = 6;
    public int numberInt2 = 3;
    int result;
    int numberRemainder;


    //�Ǽ��� ���� �����ϱ�
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;



    // ���ڿ� ���� �����ϱ�
    public string name = "�赿";
    string job = "���λ����";


    //���� ���� �����ϱ�
    public bool isMan;


    // Start is called before the first frame update
    void Start()
    {


        // ������ ����
        // ���� �̸� = ��;
        // numberSum = numberInt1 / numberint2;
        //numberRemainder = numberInt1 % numberint2;

        //number = 10;
        // number = 50;

        //number2 = 3.141592f;
        //name = "�赿��";
        //isman = false;

        //  numberResult = float numberInt1 + (float) numberint2;
        //��Ģ������ : + - * / %

        // ���ڿ� + ���ڿ� -> �� ���ڿ��� �����
        // ���� �Ǵ� �Ǽ��� ���ڿ��� ����ȯ�ϰ� ���� �� : ������.ToString()

        // string result = name + numberInt1.ToString();

        // print(result);

        //print(numberSum);
        // print(numberRemainder);

        //numberInt1�� numberInt2 ������ �հ� ���� ����Ѵ�.
        // numberSum = Sum(numberInt1, numberInt2);
        //    print(numberSum);

        result = Sum(numberInt1, numberInt2);
        print(result);

        result = Subtract(numberInt1, numberInt2);
        print(result);

        result = Multiply(numberInt1, numberInt2);
        print(result);

        numberResult = Divide(numberInt1, numberInt2);
        print(numberResult);

    }

    // Update is called once per frame
    void Update()
    {

    }

    // �Լ� ����
    // ��ȯ �ڷ��� �Լ� �̸� ( �Ű�����1, �Ű�����2, ...)
    // {
    //      �� ��
    // }

    // �� ������ �Է� �޾Ƽ� �� �� ���� �հ� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�!
    //Subtract, Multiply, Divide

  


    int Sum(int num1, int num2)
    {
        return num1 + num2;


    }
           
    int Subtract(int num1, int num2)

    { return num1 - num2;

    }

    int Multiply(int num1, int num2)
    { return num1 * num2;
    }
    //�� ������ ���� �Է� �޾Ƽ�, �� ������ ������ ����� �Ǽ����·� ��ȯ
    // �Է¹��� ������ �Ǽ��� �ӽ� ����ȯ�� �Ѵ�
    float Divide(int num1, int num2)
    { return(float) num1 /(float) num2;
        }












}
