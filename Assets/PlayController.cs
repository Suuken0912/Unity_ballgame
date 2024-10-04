using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
　　public GameObject Ball;
　　public GameObject GameOverPanel;

    private float accel = 1000.0f;

　　// Start is called before the first frame update
　　void Start()
　　{

　　}

　　// Update is called once per frame
　　void Update()
　　{
   
　　　　this.GetComponent<Rigidbody>().AddForce(
    		transform.right * Input.GetAxisRaw("Horizontal") * accel, ForceMode.Impulse);
	this.GetComponent<Rigidbody>().AddForce(
    		transform.up * Input.GetAxisRaw("Vertical") * accel, ForceMode.Impulse);
　　}

　　private void OnCollisionEnter(Collision other)
　　{
　　　　if(other.gameObject.tag == Ball.tag)
　　　　{
　　   　　　GameOverPanel.SetActive(true);
　　　　}
　　}
}
