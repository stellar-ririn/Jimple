using UnityEngine;

public class Employ_TaskEnd : MonoBehaviour
{

    [SerializeField] GameObject screen;

    private void OnMouseDown()
    {
        screen.GetComponent<Taskinfo_Employ>().EndTask();
    }
}
