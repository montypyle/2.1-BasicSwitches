using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    public Animator bulbAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();
        bulbAnimator.SetBool("Lit", false);

    }

    public void BulbOn()
    {
        bulbAnimator.SetBool("Lit", true);
    }
    public void BulbOff()
    {
        bulbAnimator.SetBool("Lit", false);
    }
}
