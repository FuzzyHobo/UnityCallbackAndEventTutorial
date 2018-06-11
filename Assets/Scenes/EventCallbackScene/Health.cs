using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventCallbacks
{
    public class Health : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Die();
            }
        }

        void Die()
        {
            // I am dying for some reason.
            new UnitDeathEvent(gameObject);
            Destroy(gameObject);
        }
    }
}