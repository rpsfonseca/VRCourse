using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    public Blaze blaze;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player" && blaze)
        {
            blaze.StartBlazing();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player" && blaze)
        {
            blaze.StopBlazing();
        }
    }
}
