using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowObjectBehaviour : MonoBehaviour { 

    [SerializeField] public Transform ObjectToFollow;

    [Range(1,50)][SerializeField] int m_FramesDelay = 10;
    List<Vector3> m_UpcomingPositions;

    public FollowObjectBehaviour(Transform ObjectToFollow, int FramesDelay)
    {
        this.ObjectToFollow = ObjectToFollow;
        this.m_FramesDelay = FramesDelay;
    }

    private void Start()
    {
        m_UpcomingPositions = new List<Vector3>();
    }

    private void FixedUpdate()
    {
        AddPosition();
        ConsumePosition();
    }
    private void AddPosition()
    {
        if (ObjectToFollow != null)
        {
            m_UpcomingPositions.Add(ObjectToFollow.position);
        }
    }
    private void ConsumePosition()
    {
        if (m_UpcomingPositions.Count > m_FramesDelay)
        {
            Vector3 nextPosition = m_UpcomingPositions[0];
            this.gameObject.transform.position = new Vector3(nextPosition.x, nextPosition.y, this.gameObject.transform.position.z);
            m_UpcomingPositions.RemoveAt(0);            
        }
    }
}
