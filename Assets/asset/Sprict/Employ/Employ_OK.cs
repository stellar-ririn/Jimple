using UnityEngine;

public class Employ_OK : MonoBehaviour
{
    [SerializeField] GameObject window;

    private void OnMouseDown()
    {
        window.GetComponent<Employ_window>().Allow();
    }
}
