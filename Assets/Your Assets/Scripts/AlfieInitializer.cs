using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alfie
{
	public class AlfieInitializer : Initializer
	{
		public sealed override void InitializeScene()
		{
			Player.Interactor.gameObject.AddComponent<Throwing>();
			Player.Interactor.gameObject.GetComponent<Throwing>().SetObject(FindObjectOfType<BallPickUp>().gameObject);
		}
		public sealed override void DeinitializeScene() 
		{
			Destroy(Player.Interactor.GetComponent<Throwing>());
        }
    }
}
