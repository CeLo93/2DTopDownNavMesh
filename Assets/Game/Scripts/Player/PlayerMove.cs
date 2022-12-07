using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    public NavMeshAgent playerAgent;

    void Start()
    {
        FixRotation2D();
    }
    void Update()
    {
        GetMouseClickPositionAndTryToMove();
    }
    void FixRotation2D()
    {
        playerAgent.updateRotation = false;
        playerAgent.updateUpAxis = false;
    }

    void GetMouseClickPositionAndTryToMove()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.playerAgent.SetDestination(mousePosition);
        }
    }
} //-------------------xx
