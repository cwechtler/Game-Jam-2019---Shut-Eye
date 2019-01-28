using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collision){
		Destroy(collision.gameObject);
		LevelManager.Instance.LoadLevel("Lose");
	}
}
