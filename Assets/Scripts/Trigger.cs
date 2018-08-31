using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
    public Triggerable target;
    public float delay;

    void OnDrawGizmos()
    {
        Color gizmoColor = new Color(0f, 0.580f, 1f, 1F);
        Gizmos.color = gizmoColor;
        if (target != null)
        {
            Gizmos.DrawLine(transform.position, target.transform.position);
        }
    }

    private void Reset()
    {
        delay = 0;
    }

    public void OnTrigger(GameObject source)
    {
        StartCoroutine(TriggerDelayed(source, delay));
    }
    
    private IEnumerator TriggerDelayed(GameObject source, float delay)
    {
        yield return new WaitForSeconds(delay);
        target.OnTrigger(source);
    }
}
