using Alfie;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegTrigger : MonoBehaviour
{
    [SerializeField] private int _requiredAmount = 3;
    [SerializeField] private GameObject _barrier;

    private int _countBalls;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BallPickUp>())
        {
            if (other.gameObject.GetComponent<BallPickUp>().GetThrowBasket())
            {
                _countBalls++;
                if (_countBalls >= _requiredAmount)
                {
                    _barrier.SetActive(false);
                }
            }
        }
    }
}
