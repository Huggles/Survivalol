using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusCollisionBehaviour : MonoBehaviour
{

    SphereCollider m_SphereCollider;

    public Boolean m_IsPlayerControlled;
    // Start is called before the first frame update
    void Start()
    {
        m_SphereCollider = this.GetComponent<SphereCollider>();
        m_IsPlayerControlled = this.GetComponentInParent<CharacterController2D>() ? true : false;
    }

    private void FixedUpdate()
    {
                
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colliders collided!");
        
        
        
    }
    private void OnTriggerStay(Collider other)
    {        
        if (other is SphereCollider)
        {
            if (!other.GetComponentInParent<VirusCollisionBehaviour>().m_IsPlayerControlled)
            {
                Destroy(other.gameObject);
            }
            //SphereCollider otherSphereCollider = (SphereCollider)other;
        }
    }
}
