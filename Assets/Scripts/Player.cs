using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed = 2;

    public float distance = 2;
    public float distanceNear = 0.5f;
    
    public LayerMask enemyLayer = 3;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //playerLayer = ~playerLayer;
        //Collider bala = Instantiate(prefab);
        //Physics.IgnoreCollision(transform.GetComponent<Collider>(), bala,true);
        //gameObject.tag = "Enemy";
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y, h*moveSpeed);

        RaycastHit hit;
        if(Input.GetButtonDown("Fire1")){
            if(Physics.Raycast(transform.position, Vector3.forward, out hit, distance,enemyLayer)){
                Debug.DrawRay(transform.position,Vector3.forward*distance,Color.red);
                //if(hit.transform.tag == "Enemy")
                    //Debug.Log("Acertou Miseravi");
            }else{
                Debug.DrawRay(transform.position,Vector3.forward*distance,Color.yellow);
            }
        }
    }

    void OnTriggerEnter(Collider other){
        IDamageable obj = other.GetComponent<IDamageable>();

        if(obj != null){
            obj.TakeDamage();
            score+=10;
        }

        if(other.tag == "Fire"){
            other.GetComponent<ParticleSystem>().Play();
        }
    }
}
