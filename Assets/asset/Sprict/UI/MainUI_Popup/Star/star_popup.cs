using UnityEngine;

public class star_popup : MonoBehaviour
{
    [SerializeField] GameObject starobj;
    private void OnMouseDown()
    {
        starobj.SetActive(false);
    }
}
