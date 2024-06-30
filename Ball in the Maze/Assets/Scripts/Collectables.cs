using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ScoreManager.instance.AddScore(1);
            Invoke("DestroyCollectables", 0.2f);
            // Debug.Log("Ball Collided with coin");
        }
    }
    void DestroyCollectables()
    {
        Destroy(this.gameObject);
    }
}
