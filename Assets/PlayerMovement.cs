using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * 5, Input.GetAxis("Vertical") * 5);
    }
    
    private void OnCollisionEnter2D(Collision2D door)
    {
        //Debug.Log("Collision detected with: " + door.gameObject.name);
        //Debug.Log("Object tag: " + door.gameObject.tag);
        if (door.gameObject.tag == "Door")
        {
            //Debug.Log("Loading scene: winscreen");
            SceneManager.LoadScene("winscreen");
        }
    }
}
