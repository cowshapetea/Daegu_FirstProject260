using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze2 : SwordMan
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Move()
    {
        //�θ��� Move �Լ��� �����Ѵ�.
        base.Move();
        print("ôôô �ϸ鼭 ���ڱ� �Ҹ��� ���ϴ�");
    }

}
