using UnityEngine;
using UnityEngine.Tilemaps;

public class ShadowController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            var light = this.gameObject.GetComponent<Light>();
            light.enabled = true;
        }
    }
}
