using System.Collections;
using UnityEngine;

public class NightMover : MonoBehaviour {

	[SerializeField] float speed = 10f;

	private float defaultSpeed;

	private void Start(){
		defaultSpeed = speed;
	}

	void Update () {
		transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

	public void PauseNight() {
		StartCoroutine(NightPause());
	}

	private IEnumerator NightPause(){
		speed = 0;
		yield return new WaitForSeconds(2);
		speed = defaultSpeed;
	}
}
