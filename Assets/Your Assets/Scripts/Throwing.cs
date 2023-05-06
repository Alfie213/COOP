using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Alfie
{
	public class Throwing : MonoBehaviour
	{
        [SerializeField] private GameObject _objectToThrow;
        [SerializeField] private float _throwForce = 10f;
        [SerializeField] private float _upwardForce = 5f;
        [SerializeField] private float _timeToDestroy = 3f;

        public void SetObject(GameObject obj)
        {
            _objectToThrow = obj;
        }

        private void Update()
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
                Debug.Log(gameObject.name);
                Throw();
            }
		}

		private void Throw()
        {
            GameObject obj = Instantiate(_objectToThrow, Player.Interactor.transform.parent.parent.parent.transform.position, Player.Interactor.transform.parent.parent.parent.transform.rotation); 
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * _throwForce + transform.up * _upwardForce, ForceMode.Impulse);
            //Debug.Log($"Throwed at {Player.Interactor.transform.parent.parent.parent.position}");
            Destroy(obj, _timeToDestroy);
        }
    }
}
