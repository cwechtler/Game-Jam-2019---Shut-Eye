using UnityEngine;

public class Collector : MonoBehaviour {

    private GameObject nightMoverGO;
    private NightMover nightMover;

    private void Start() {
        nightMoverGO = GameObject.FindGameObjectWithTag("Night Mover");
        nightMover = nightMoverGO.GetComponent<NightMover>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        Destroy(gameObject);
        nightMover.PauseNight();
        SoundManager.instance.PlayCollectClip();

    }

}
