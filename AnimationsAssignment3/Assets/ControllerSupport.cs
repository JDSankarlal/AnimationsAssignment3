using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSupport : MonoBehaviour {

    private Animator control;
    float x;
    float y;
    float jump;
    float strong;
    float weak;

    // Use this for initialization
    void Start () {
        control = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        x = Input.GetAxis("Horizontal");
        control.SetFloat("x", x);
        y = Input.GetAxis("Vertical");
        control.SetFloat("y", y);
        jump = Input.GetAxis("Jump");
        control.SetFloat("jump", jump);
        strong = Input.GetAxis("HeavyAttack");
        control.SetFloat("strong", strong);
        weak = Input.GetAxis("WeakAttack");
        control.SetFloat("weak", weak);

        //transform.Rotate(0, x, 0);
        //transform.Translate(x, 0, z);

        Debug.Log(jump);
        Debug.Log(strong);
        Debug.Log(weak);
        Debug.Log(x);
        Debug.Log(y);




    }
}
