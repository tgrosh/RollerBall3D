using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerableText : Triggerable {
    public override void OnTrigger(GameObject source)
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }

    // Use this for initialization
    void Start () {
        gameObject.SetActive(false);
	}
}
