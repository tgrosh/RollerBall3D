using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger : Triggerable {
    [Tooltip("Turns the Switch OFF (Default ON)")]
    public bool triggerOff;
    public Switchable target;

    void OnDrawGizmos()
    {
        Color gizmoColor = new Color(0f, 0.580f, 1f, 1F);
        Gizmos.color = gizmoColor;
        if (target != null)
        {
            Gizmos.DrawLine(transform.position, target.transform.position);
        }
    }

    public override void OnTrigger(GameObject source)
    {
        if (!triggerOff)
        {
            target.On(source);
        }
        else
        {
            target.Off(source);
        }
    }
}
