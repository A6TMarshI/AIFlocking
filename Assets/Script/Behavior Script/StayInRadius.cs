using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Flock/Behavior/Stay in radius")]
public class StayInRadius : FlockBehavior
{
    public Vector3 center;
    public float radius = 15f;
    public override Vector3 Movement(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector3 centerOffset = center - agent.transform.position;
        float u = centerOffset.magnitude / radius;
        if(u<0.9f)
        { 
            return Vector3.zero;
        }
        return centerOffset * u * u;
    }
}
