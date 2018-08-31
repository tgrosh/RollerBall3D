using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGroup : Triggerable
{
    public TriggerGroupTarget[] groupTargets;

    void OnDrawGizmos()
    {
        Color gizmoColor = new Color(0f, 0.580f, 1f, 0.5F);
        Gizmos.color = gizmoColor;
        Gizmos.DrawSphere(transform.position, transform.localScale.magnitude);

        gizmoColor.a = 1f;
        Gizmos.color = gizmoColor;
        foreach (TriggerGroupTarget groupTarget in groupTargets)
        {
            Gizmos.DrawLine(transform.position, groupTarget.target.transform.position);
        }
    }

    public override void OnTrigger(GameObject source)
    {
        foreach (TriggerGroupTarget groupTarget in groupTargets)
        {
            StartCoroutine(TriggerDelayed(groupTarget.target, source, groupTarget.delay));
        }
    }

    private IEnumerator TriggerDelayed(Triggerable target, GameObject source, float delay)
    {
        yield return new WaitForSeconds(delay);
        target.OnTrigger(source);
    }
}
