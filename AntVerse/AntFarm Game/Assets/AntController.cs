using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AntController : MonoBehaviour
{
    [SerializeField]public RaycastHit hit;
    public Vector3 clickPos;
    public float speed;
    public NavMeshAgent agent;
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                clickPos = hit.point;
                agent.destination = hit.point;
            }
        }
    }
}
