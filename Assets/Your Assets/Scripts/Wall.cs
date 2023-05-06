using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Alfie
{
	public class Wall : MonoBehaviour
	{
		[SerializeField] private int _health = 100;
		[SerializeField] private TextMeshProUGUI _healthTMP;

		private void Awake()
		{
			_healthTMP.text = _health.ToString();
		}

		private void OnCollisionEnter(Collision collision)
		{
            if (collision.gameObject.GetComponent<BallPickUp>())
            {
                //Debug.Log("Hit");
                _health--;
				_healthTMP.text = _health.ToString();
				if (_health <= 0)
				{
					_healthTMP.text = string.Empty;
					//Debug.Log("all");
					Destroy(gameObject);
				}
            }
        }
	}
}
