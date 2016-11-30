using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public float moveSpeed;
    public float turnSpeed;
    public KeyCode pressUp;
    public KeyCode pressDown;
    public KeyCode pressLeft;
    public KeyCode pressRight;



	// Use this for initialization
	void Start () {
        moveSpeed = 1f;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
   
        
       
       /*
        if (Input.GetKeyDown(pressLeft))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(-90, 91, 56);
        }
        if (Input.GetKeyDown(pressRight))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        } */


    }
}
