using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    private Animator bulbAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();   
    }

}
