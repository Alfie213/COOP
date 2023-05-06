using Alfie;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BallPickUp>())
        {
            other.gameObject.GetComponent<BallPickUp>().SetThrowBasket(true);
        }
    }
}
