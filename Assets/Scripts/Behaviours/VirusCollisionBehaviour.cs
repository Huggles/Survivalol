using PubSub;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other is SphereCollider)
        {
            if (!other.GetComponentInParent<VirusCollisionBehaviour>().m_IsPlayerControlled)
            {
                Destroy(other.gameObject);
                FoodTakenEvent foodTakenEvent = new FoodTakenEvent(1);
                Hub.Default.Publish(foodTakenEvent);
            }
        }
    }
}
