using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alfie
{
	public class Gun : MonoBehaviour
	{
        public ParticleSystem muzzleFlash;
        public GameObject impactEffect;
        public float range = 100f;

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }

        void Shoot()
        {
            muzzleFlash.Play();

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 2f);
            }
        }
    }
}
