using UnityEngine;

public class WinCollider : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelManager.Instance.LoadLevel("Win");
    }
}
