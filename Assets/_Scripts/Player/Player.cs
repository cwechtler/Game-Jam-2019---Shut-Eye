
using UnityEngine;
using UnityStandardAssets._2D;
public class Player : MonoBehaviour {

	PlatformerCharacter2D platformerCharacter2D;

	private void Start()
	{
		platformerCharacter2D = GetComponent<PlatformerCharacter2D>();
	}
	private void Update()
	{
		if (Input.GetButtonDown("Jump") && platformerCharacter2D.Grounded)
		{
			SoundManager.instance.PlayJump();
		}
	}
}
