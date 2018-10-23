using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public Animator minotaurAnimator;

    public int health = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Spear") && health > 0)
        {
            health -= 10;
            if (health == 0)
            {
                minotaurAnimator.Play("Die");
                StartCoroutine("DestroyMinotaur");
            }
        }
    }

    IEnumerator DestroyMinotaur()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}
