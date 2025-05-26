using UnityEngine;

public class ListOff : MonoBehaviour
{
    [SerializeField] GameObject tasks;

    private void OnMouseDown()
    {
        tasks.SetActive(false);
    }
}
