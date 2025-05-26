using UnityEngine;

public class Employ_screen : MonoBehaviour
{
    // アバターに割り振られたタスクの記憶。
    public int taskpoint;
    public int tasknum;
    public string taskInfo;

    public int nowtype; //現在画面の管理い


    [SerializeField] GameObject taskscreen;
    [SerializeField] GameObject endScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        taskscreen.SetActive(false);
        endScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InTask() // タスクが割り振られた時に
    {
        taskscreen.SetActive(true);
    }

    public void InEnd() // タスク終わったら
    {
        endScreen.SetActive(true);
    }
}
