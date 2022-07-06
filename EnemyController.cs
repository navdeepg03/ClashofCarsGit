using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerCurrentPosition;
    private Vector3 direction;
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerCurrentPosition = player.transform.position;
        direction = transform.position - playerCurrentPosition;
        direction /= 2;
        Debug.Log("x: " + direction.x + "z: " + direction.z);
         
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position = Vector3.MoveTowards(transform.position, playerCurrentPosition, enemySpeed * Time.deltaTime);  
        transform.Translate(-direction.x * 0.001f * enemySpeed, 0f, -direction.z * 0.001f * enemySpeed);
  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Play Animation
            Destroy(this.gameObject);
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Border")
        {
            // Play Animation
            Destroy(this.gameObject);  
        }
        if (other.gameObject.tag == "Enemy")
        {
            //Play Animation
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }


    }
}  
