using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class CharacterMotor : MonoBehaviour
{
    Animator m_Animator;
    public UnityEngine.AI.NavMeshAgent agent;//Reference to Agent
    public Transform target; //Target to Follow
    private NpcActions npca; 
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
