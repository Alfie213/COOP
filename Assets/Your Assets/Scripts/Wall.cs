using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alfie
{
	public class Wall : MonoBehaviour
	{
		[SerializeField] private int _health = 10;

		private void OnCollisionEnter(Collision collision)
		{
            if (collision.gameObject.GetComponent<BallPickUp>())
            {
                Debug.Log("Hit");
                _health--;
				if (_health <= 0)
				{
					Destroy(this);
				}
            }
        }
	}
}
