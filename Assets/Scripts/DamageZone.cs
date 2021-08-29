using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        Debug.Log("DamageZone Script");

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }

}
