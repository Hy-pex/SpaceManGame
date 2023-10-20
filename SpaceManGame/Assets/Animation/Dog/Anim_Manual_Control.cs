using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Anim_Manual_Control : MonoBehaviour
{
    [SerializeField]
    private Animator AnimController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            AnimController.SetTrigger("Anim_0");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AnimController.SetTrigger("Anim_1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AnimController.SetTrigger("Anim_2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            AnimController.SetTrigger("Anim_3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            AnimController.SetTrigger("Anim_4");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            AnimController.SetTrigger("Anim_5");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            AnimController.SetTrigger("Animation_0");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            AnimController.SetTrigger("Animation_1");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            AnimController.SetTrigger("Animation_2");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            AnimController.SetTrigger("Animation_3");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            AnimController.SetTrigger("Animation_4");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            AnimController.SetTrigger("Animation_5");
        }
        
    }
}
