using UnityEngine;

public class ShadowController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get position of collided tile
        var tilePos = collision.collider.transform.position;

        // Fade colour of tile
        

    }
}
