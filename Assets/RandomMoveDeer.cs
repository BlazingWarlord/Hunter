using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMoveDeer : MonoBehaviour
{
    int movedir;
    float countdown;
    float delayrandom = 5f;
    int waitormove = 0;
    Transform player;
    public NavMeshAgent agent;
    Vector3 movedire;
    float step;
    int x, y;
    public GameObject playerbody;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delayrandom;
        x = Random.Range(-50, 50);
        y = Random.Range(-50, 50);
        player = playerbody.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!CheckPlayer())
        {
            step = 2f * Time.deltaTime;
            
            
            

                x = Random.Range(-50, 50);
                y = Random.Range(-50, 50);
                movedire = new Vector3(x, 0, y);
            agent.speed = 2f;
                agent.SetDestination(movedire);
                countdown = delayrandom;



            
        }
        else
        {
            Vector3 runTo = transform.position + ((transform.position - player.position) * 5f);
            float distance = Vector3.Distance(transform.position, player.position);
            agent.SetDestination(runTo);
            agent.speed = 30f;
        }
    }

    bool CheckPlayer()
    {
        if (Vector3.Distance(player.position, transform.position) <= 100f)
        {

            return true;
            
        }
        else
        {
            return false;
        }
    }
}
