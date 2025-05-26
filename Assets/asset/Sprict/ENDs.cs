using UnityEngine;

public class ENDs : MonoBehaviour
{

    public int tasknum;
    [SerializeField] GameObject systems;
    [SerializeField] GameObject chara;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void END()
    {
        systems.GetComponent<Sys_nowDoing>().EndTask(tasknum);
        chara.GetComponent<Chara01sp>().ifWork = false;
        tasknum = 0;
    }

    private void OnMouseDown()
    {
        tasknum = chara.GetComponent<Chara01sp>().tasknum;
        END();
    }
}
