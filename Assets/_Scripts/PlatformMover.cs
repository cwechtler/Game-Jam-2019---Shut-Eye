
using UnityEngine;

public class PlatformMover : MonoBehaviour {

	[SerializeField] float speed = 5f;
	[SerializeField] bool horizontal;
	
	private bool up;
	private bool down;

	private float leftAmount;
	private float rightAmount;
	private float bottomAmount;
	private float topAmount;

	void Start () {
		leftAmount = transform.position.x;
		rightAmount = transform.position.x + 10f;
		bottomAmount = transform.position.y;
		topAmount = transform.position.y + 7f;
	}
	
	void Update () {
		if (horizontal){
			if (transform.position.y >= topAmount){
				up = false;
				down = true;
			}
			else if (transform.position.y <= bottomAmount){
				up = true;
				down = false;
			}

			if (up){
				transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
			}
			else if (down){
				transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
			}
		}
		else if (!horizontal) {
			if (transform.position.x >= rightAmount)
			{
				up = false;
				down = true;
			}
			else if (transform.position.x <= leftAmount)
			{
				up = true;
				down = false;
			}

			if (up)
			{
				transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
			}
			else if (down)
			{
				transform.Translate(new Vector3(0, 0 ,-speed * Time.deltaTime));
			}
		}
	}
}
