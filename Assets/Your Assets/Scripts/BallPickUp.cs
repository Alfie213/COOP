using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alfie
{
	public class BallPickUp : Pickup
	{
		[SerializeField] private float _throwForce;
		[SerializeField] private float _upwardForce;
        public override void OnDrop(Inventory inventory)
		{
			GameObject ball = Player.Inventory.HoldedPickup.gameObject;

            GameObject obj = Instantiate(ball, transform.position, transform.rotation);
            Rigidbody rb = obj.GetComponent<Rigidbody>();

            rb.AddForce(transform.forward * _throwForce + transform.up * _upwardForce, ForceMode.Impulse);

            //Debug.Log(ball.name);
			base.OnDrop(inventory);
			//player
		}

		public override void OnTryInteract(Interactor interactor) { }
	}
}
