using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    public float minX, maxX, minY, maxY;
    public GameObject laserBeam;
    public GameObject laserBeamSpawner;

    private float fireRate = 0.25f;
    private float timer = 0;
    void Start()
    {
        playerSpeed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement;
        float verticalMovement;
        
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        //Debug.Log("H: " + horizontalMovement + " ,V " + verticalMovement);

        Vector2 newVelocity = new Vector2(horizontalMovement, verticalMovement);
        GetComponent<Rigidbody2D>().velocity = newVelocity * playerSpeed;

        float newX, newY;

        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, minX, maxX);
        newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, minY, maxY);

        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY);

        if (Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {
            GameObject  goObj;
            goObj = GameObject.Instantiate(laserBeam, laserBeamSpawner.transform.position, laserBeamSpawner.transform.rotation);
            goObj.transform.Rotate(0.0f, 0.0f, 0.0f);
            timer = 0;

        }
        timer += Time.deltaTime;
    }
}
