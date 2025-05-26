using UnityEngine;

public class Chara01_icon : MonoBehaviour
{
    private Animator animator = null;

    public bool inMove = false;
    public bool inWork = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(inMove == true)
        {
            animator.SetBool("inMove", true);
        } else
        {
            animator.SetBool("inMove", false);
        }

        if(inWork == true)
        {
            animator.SetBool("InWork", true);
        } else
        {
            animator.SetBool("InWork", false);
        }
    }
}
