using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchArea : Switchable {
    public bool persistent = false;
    public bool inverse = false;

    List<Rigidbody> currentRoots = new List<Rigidbody>();
    bool areaActive = true;
    
    void OnDrawGizmos()
    {
        Color gizmoColor = new Color(0.901f, 0.678f, 0.898f, 0.25F);
        Gizmos.color = gizmoColor;
        Gizmos.DrawCube(transform.position, GetComponent<BoxCollider>().bounds.size);

        gizmoColor.a = 1f;
        Gizmos.color = gizmoColor;
        Gizmos.DrawLine(transform.position, GetComponent<Switch>().target.transform.position);
    }

    void Reset()
    {
        persistent = false;
    }
        
    void OnTriggerEnter(Collider collider)
    {
        if (!areaActive) return;

        Rigidbody rootRigidBody = collider.gameObject.GetComponentInParent<Rigidbody>();

        if (rootRigidBody == null)
        {
            return;
        }

        if (currentRoots.Contains(rootRigidBody))
        {
            return;
        }

        if (rootRigidBody.GetComponentInParent<Ball>() == null)
        {
            return;
        }
        
        currentRoots.Add(rootRigidBody);
        if (!inverse)
        {
            GetComponent<Switch>().On(gameObject, persistent);
        } else
        {
            GetComponent<Switch>().Off(gameObject);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (!areaActive) return;

        Rigidbody rootRigidBody = collider.gameObject.GetComponentInParent<Rigidbody>();

        if (rootRigidBody == null)
        {
            return;
        }

        if (rootRigidBody.GetComponentInParent<Ball>() == null)
        {
            return;
        }

        if (currentRoots.Contains(rootRigidBody))
        {
            currentRoots.Remove(rootRigidBody);
            if (inverse)
            {
                GetComponent<Switch>().On(gameObject, persistent);
            }
            else
            {
                GetComponent<Switch>().Off(gameObject);
            }
        }        
    }

    public override void On(GameObject origin)
    {
        areaActive = true;
    }

    public override void Off(GameObject origin)
    {
        areaActive = false;
    }
}
