using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    //정수형 변수 선언하기
    public int numberInt1 = 6;
    public int numberInt2 = 3;
    int result;
    int numberRemainder;


    //실수형 변수 선언하기
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;



    // 문자열 변수 선언하기
    public string name = "김동";
    string job = "개인사업자";


    //논리형 변수 선언하기
    public bool isMan;


    // Start is called before the first frame update
    void Start()
    {


        // 변수의 사용법
        // 변수 이름 = 값;
        // numberSum = numberInt1 / numberint2;
        //numberRemainder = numberInt1 % numberint2;

        //number = 10;
        // number = 50;

        //number2 = 3.141592f;
        //name = "김동휘";
        //isman = false;

        //  numberResult = float numberInt1 + (float) numberint2;
        //사칙연산자 : + - * / %

        // 문자열 + 문자열 -> 두 문자열이 연결됨
        // 정수 또는 실수를 문자열로 형변환하고 싶을 때 : 변수명.ToString()

        // string result = name + numberInt1.ToString();

        // print(result);

        //print(numberSum);
        // print(numberRemainder);

        //numberInt1과 numberInt2 변수의 합계 값을 출력한다.
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

    // 함수 선언
    // 반환 자료형 함수 이름 ( 매개변수1, 매개변수2, ...)
    // {
    //      할 일
    // }

    // 두 정수를 입력 받아서 그 두 수의 합계 값을 정수 형태로 반환하는 함수를 만들고 싶다!
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
    //두 정수의 값을 입력 받아서, 두 정수의 나눗셈 결과를 실수형태로 반환
    // 입력받은 정수를 실수로 임시 형변환을 한다
    float Divide(int num1, int num2)
    { return(float) num1 /(float) num2;
        }












}
