using UnityEngine;
using System.Collections.Generic;

public class Sys_nowDoing : MonoBehaviour
{
    // なんかこう、おくとこ
    public int nowDoing = 0;
    public int task = 0;

    //------終わったタスクはfalseに------------
    public bool task0 = true;
    public bool task1 = true;
    public bool task2 = true;
    public bool task3 = true;
    public bool task4 = true;
    public bool task5 = true;
    public bool task6 = true;
    public bool task7 = true;
    public bool task8 = true;

    public int EndTask(int num)
    {
        switch (num)
        {
            case 0:
                task0 = false;
                break;
            case 1:
                task1 = false;
                break;
            case 2:
                task2 = false;
                break;
            case 3:
                task3 = false;
                break;
            case 4:
                task4 = false;
                break;
            case 5:
                task5 = false;
                break;
            case 6:
                task6 = false;
                break;
            case 7:
                task7 = false;
                break;
            case 8:
                task8 = false;
                break;
        }
        return 0;
    }
}
