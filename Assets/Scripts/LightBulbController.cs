using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulbController : MonoBehaviour {

    private Animator lightAnimator;
    public SwitchController theSwitch; 

    private void Awake()
    {
        lightAnimator = GetComponent<Animator>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
	}
    public void LightOn ()
    {
        lightAnimator.SetBool("LightOn",true);
    }
}
