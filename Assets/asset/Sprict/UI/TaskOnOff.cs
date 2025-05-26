using UnityEngine;

public class TaskOnOff : MonoBehaviour
{
    [SerializeField] GameObject tasks;

    [SerializeField] GameObject slaveView1;
    [SerializeField] GameObject slaveView2;
    [SerializeField] GameObject slaveView3;

    private void OnMouseDown()
    {
        slaveView1.SetActive(false);
        slaveView2.SetActive(false);
        slaveView3.SetActive(false);

        if (tasks.active == false)
        {
            tasks.SetActive(true);
        } else
        {
            tasks.SetActive(false);
        }
    }

    private void Start()
    {
        tasks.SetActive(false);
    }
}
