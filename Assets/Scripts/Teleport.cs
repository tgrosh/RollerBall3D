using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : Switchable {
    public bool isActive = true;
    public Teleport destination;

    private GameObject incomingTeleportSubject;

    void OnDrawGizmos()
    {
        Color gizmoColor = new Color(0f, 0.580f, 1f, 1F);
        Gizmos.color = gizmoColor;
        if (destination != null)
        {
            Gizmos.DrawLine(transform.position, destination.transform.position);
        }
    }

    public override void Off(GameObject origin)
    {
        isActive = false;
    }

    public override void On(GameObject origin)
    {
        isActive = true;
    }

    public void TeleportTo(GameObject subject)
    {
        incomingTeleportSubject = subject;
        subject.GetComponentInParent<Rigidbody>().MovePosition(transform.position);
    }

    private void Reset()
    {
        isActive = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isActive && incomingTeleportSubject != other.gameObject)
        {
            destination.TeleportTo(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        incomingTeleportSubject = null;
    }
}
