using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    public Blaze blaze;

    public bool spearThrow = false;

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
            spearThrow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player" && blaze)
        {
            blaze.StopBlazing();
            spearThrow = false;
        }
    }
}
