using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// Public variables
	public float speed = 10.0f; //Speed of the player
	public float stutter = 1.0f; //Failure rate of movement entry
	public float gravityScale = 0;

	// MonoBehaviour object components
	Rigidbody2D rb;
	CircleCollider2D cc;
	SpriteRenderer sr;
	Animator anim;


	void Awake()
	{
		// Get references to our components
		rb = GetComponent<Rigidbody2D>();
		cc = GetComponent<CircleCollider2D>();
		anim = GetComponent<Animator>();
	}

    // Start is called before the first frame update
    void Start()
    {
		// Turn gravity off? needs to be tested.
		rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
		// Turn off gravity
		rb.GetComponent<Rigidbody2D>().gravityScale = 0.0f;

		//if (stutter >= Random.Range(0.0f, 1.0f)) // TODO: failing due to age or something?
		//{
			MoveHorizontal(Input.GetAxis("Horizontal")); //		
			MoveVertical(Input.GetAxis("Vertical")); //
		//}
        if (Mathf.Abs(Input.GetAxis("Horizontal")) <= 0.1 && Mathf.Abs(Input.GetAxis("Vertical")) <= 0.1)
        {
            anim.SetBool("Moving", false);
        }
    }

	void MoveHorizontal(float input)
	{
		Vector2 moveVel = rb.velocity; //Get our current rigidbody's velocity
		moveVel.x = input * speed * Time.deltaTime; //Set the new x velocity to be the given input times our speed
		//Note the multiply by Time.deltaTime to compensate for game clock//
		rb.velocity = moveVel;//Update our rigidbody's velocity
        if (Mathf.Abs(input) > 0.01)
        {
            anim.SetBool("Moving", true);
        }
        if (input > 0)
        {
            anim.SetBool("FaceUp", false);
            anim.SetBool("FaceDown", false);
            anim.SetBool("FaceRight", true);
            anim.SetBool("FaceLeft", false);
        }
        else if (input < 0)
        {
            anim.SetBool("FaceUp", false);
            anim.SetBool("FaceDown", false);
            anim.SetBool("FaceLeft", true);
            anim.SetBool("FaceRight", false);
        }
    }

	void MoveVertical(float input)
	{
		Vector2 moveVel = rb.velocity; //Get our current rigidbody's velocity
		moveVel.y = input * speed * Time.deltaTime; //Set the new x velocity to be the given input times our speed
		//Note the multiply by Time.deltaTime to compensate for game clock
		rb.velocity = moveVel;//Update our rigidbody's velocity
        if (Mathf.Abs(input) > 0.01)
        {
            anim.SetBool("Moving", true);
        }

        if (input > 0)
        {
            anim.SetBool("FaceLeft", false);
            anim.SetBool("FaceRight", false);
            anim.SetBool("FaceUp", true);
            anim.SetBool("FaceDown", false);
        }
        else if (input < 0)
        {
            anim.SetBool("FaceLeft", false);
            anim.SetBool("FaceRight", false);
            anim.SetBool("FaceDown", true);
            anim.SetBool("FaceUp", false);
        }
    }

}
