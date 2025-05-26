using UnityEngine;

public class TaskSerect_camsel : MonoBehaviour
{
    [SerializeField] GameObject systems;

    private void OnMouseDown()
    {
        systems.GetComponent<Sys_nowDoing>().nowDoing = 4;
    }
}
