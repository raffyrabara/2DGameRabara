using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float ObjectSpeed;
    Transform NexPos;
    int NexPosIndex;
    void Start()
    {
        NexPos = Positions[0];
    }

    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if(transform.position == NexPos.position)
        {
            NexPosIndex++;
            if(NexPosIndex >= Positions.Length)
            {
                NexPosIndex = 0;
            }
            NexPos = Positions[NexPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NexPos.position, ObjectSpeed * Time.deltaTime);
        }
    }
}
