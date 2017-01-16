using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

    public Rigidbody2D rocket;
    public float speed;

    private Animator anim;

	void Awake () {
        anim = transform.root.gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("Shoot");

            Rigidbody2D bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
            bulletInstance.velocity = new Vector2(speed, 0);
        }
	}
}
