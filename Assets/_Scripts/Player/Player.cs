
using UnityEngine;

public class Player : MonoBehaviour {

	private void Update()
	{
		if (Input.GetButtonDown("Jump"))
		{
			SoundManager.instance.PlayJump();
		}
	}
}
