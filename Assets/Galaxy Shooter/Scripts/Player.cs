using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject laserPrefab;

    public float fireRate = 0.25f;
    public float canFire = 0.0f;

    [SerializeField]
    private float speed = 5.0f;

	// Use this for initialization
	void Start () {
        // Debug.Log("Name " + name);
        //  Debug.Log("x pos " + transform.position.x);
        // assign position 0,0,0
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update () {
        Movement();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time > canFire)
            {
                Instantiate(laserPrefab, transform.position + new Vector3(0, 0.88f, 0), Quaternion.identity);
                canFire = Time.time + fireRate;
            }
        }
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime); // "speed" meters per second
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime); // "speed" meters per second

        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        /*
        if(transform.position.x > 8)
        {
            transform.position = new Vector3(8, transform.position.y, 0);
        } else if(transform.position.x < -8)
        {
            transform.position = new Vector3(-8, transform.position.y, 0);
        }
        */
        if (transform.position.x > 9.5f)
        {
            transform.position = new Vector3(-9.5f, transform.position.y, 0);
        }
        else if (transform.position.x < -9.5f)
        {
            transform.position = new Vector3(9.5f, transform.position.y, 0);
        }
    }

    // --> stopped at 027
}
