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
        #region 조건문
        //조건문
        // it(조건식)
        // {
        // 조건이 참 일때, 해야할 일
        // }
        // else if(조건식)
        // {
        // 두번째 조건식이 참 일때, 해야할 일
        // }
        // else
        // {
        // 앞에 있는 모든 조건들이 다 성립하지 않을 때, 해야할 일
        // }
        #endregion 조건문

        #region Example 1

        //if(age1 == age2)
        //{
        //    print("age1이 age2와 나이가 같습니다");
        //}

        //if(age1 > age2)
        //{
        //    print("age1이 age2보다 나이가 많습니다");
        //}
        //if (age1 < age2)
        //{
        //    print("age1이 age2보다 나이가 적습니다");
        //}

        //if(age1 != age2)
        //{
        //    print("age1이 age2와 나이가 서로 다릅니다");

        //}

        // age1의 나이를 기준으로 10대부터 40대까지 어느곳에 해당하는지를 출력한다.
        // 예) "age1은 30대 입니다."

        //if (age1 < 20)
        //{
        //    print("age1은 10대 입니다.");

        //}
        //else if (age1 < 30)
        //{
        //    print("age1은 20대 입니다.");

        //}
        //else if (age1 < 40)
        //{
        //    print("age1은 30대 입니다.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1은 40대 입니다.");

        //}
        //else
        //{ print("age1의 나이는 50세 이상입니다."); }





        //if(age1 >= 20)
        //{
        //    print("age1의 나이는 20살 이상입니다");

        //}

        //else
        //{ print("age1의 나이는 20살 미만입니다."); }

        #endregion Example 1

        #region Example 2

        // 1. and 조건
        // 만일, 성별이 여성이고 나이가 20살 이상일 경우
        //"성인 여성입니다"라고 출력한다.

        //if(isMan == false && age1 >= 20)
        //{ print("성인 여성입니다."); }

        //else { print("미성년자이거나, 남성입니다."); }

        // 2. or 조건
        // 만일, 움직이는 경우라면 "이동 중입니다."라고 출력하고,
        // 그렇지 않으면, "정지한 상태입니다." 라고 출력한다.

        //if (runState == true || walkState == true)

        //{ print("이동 중입니다."); }

        //else { print("정지한 상태입니다."); }

        // bool 변수를 조건문의 조건으로 넣었을 때 생략 방법
        //if(runState == true)
        //와 아래가 같고
        //if(runState)

        //if(runState == false)
        //와 아래가 같다
        //if(!runState)



        #endregion Example 2


        #region 반복문
        // 반목문
        // for (시작 변수 선언 및 초기화 ; 종료 조건식; 증감식 )
        // {
        // 반복해서 수행할 내용
        // }

        // 1부터 10까지 모든 정수를 출력한다.

        // for(int i = 0; i < 20; i = i + 1)
        // { print(i + 1);  }

        // 1부터 100까지 다 더한 값을 sum 이라는 변수에 저장해서 출력한다.

        //for (int i = 0; i < endCount; i = i + 1)
        //{ sum = sum + i + 1; }    
        //print(sum);

        for (int i = 0; i < endCount; i = i + 1)
        { sum = sum + i + 1; }
        print("원하시는 합계 값은 " + sum.ToString() + "입니다.");

        // 위 아래 둘(셋) 다 가능

        //for (int i = 0; i < 100; i = i + 1)
        //{ sum = sum + i + 1; }    
        //print(sum);

        #endregion 반복문

        #region 누적식
        // 누적식
        // int num = 0;

        // num = num + 1;
        // num += 1;
        // num ++;
        // num --;
        // num -= 1;
        // B언어 진화 C언어 진화 C++(1증가) 진화 C#(++++, 2?증가)

        #endregion 누적식

        #region 문제1

        // 문제) 1부터 20까지 중에 짝수만 출력한다.
        // 1. 20번 반복한다.
        //for (int i = 0; i < 20; i++)
        //{
        //    int number = i + 1;
        //    // 2. 만일 number의 값을 2로 나눈 나머지가 0이라면
        //    if (number % 2 == 0)
        //    // 3. 그 number를 출력한다.
        //    { print(number); }

        #endregion 문제1

        #region 문제2

        // 문제) 0부터 endCount 전까지 짝수만 출력한다. 그런데 출력된 짝수의 수가 10개에 도달하면 반복을 종료한다.

        // 1. 0부터 endCount 전까지 반복한다.
        for (int i = 0; i < endCount; i++)
        {
            // 2. 증가되는 값에서 2로 나눈 나머지가 0인 경우에는 출력한다.
            if (i % 2 == 0)
            {
                print(i);
                // 3. printCount 변수에 출력한 횟수를 증가시킨다.
                printCount++;
                // 만약 printCount의 값이 10에 도달하면 반복을 종료한다.
                if (printCount >= printMax)

                { break; }

                //for (int endCount = 0; endCount < 100; endCount++)
                //{ int number = endCount + 1;
                //    if (number % 2 == 0) break = 10);
                //    { print(number); } }



            }



        }
        #endregion 문제2


        #region for if 중첩하기

        // for 문과 if 문은 서로 중첩해서 사용할 수 있다.

        // 만일 성별이 남성이면서, 나이가 20세 이상인 경우
        // if(isMan && age1 >= 20)
        //{}
        //else{}
        //if (isMan)
        //{  if (age1 >= 20){} else{} }

        #endregion for if 중첩

        #region 구구단

        //for (int i = 2; i < 10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    { print(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString()); }

        #endregion 구구단

        #region 별 피라미드

        // *
        // **
        // ***
        // ****
        // *****

        // < 풀이 1번 >
        //string star = "";
        //for (int i = 0; i < 5; i++)
        //{ star += "*";
        //    print(star); }

        //// < 풀이 2번 >
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

        #endregion 별 피라미드

        #region 고의로 오류 만들기

        ////print("hello world");
        //Debug.Log("Hello World");
        //Debug.LogWarning("Hello World");
        //Debug.LogError("Hello World");

        #endregion 고의로 오류 만들기

    }



















}
