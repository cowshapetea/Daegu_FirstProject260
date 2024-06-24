using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Maze : SwordMan
{
    // Start is called before the first frame update
    void Start()
    {
        //MoverForward();
        //MoverForward();
        Move();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public override void Move()
    {
        base.Move();

        print("먼지가 발생합니다");
    }
    
    // print("앞으로 간다");
}
    
