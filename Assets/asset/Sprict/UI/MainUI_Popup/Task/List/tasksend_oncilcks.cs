using UnityEngine;

public class tasksend_oncilcks : MonoBehaviour
{
    public GameObject obj;

    private void OnMouseDown()
    {
        obj.GetComponent<SentTask>().Send_task();
    }
}
