//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Crep : MonoBehaviour
//{

//    //public GameObject Gun;
//    public GameObject Bullet;
//    public float FireRate;
//    float nextTimeToFire = 0;
//    public Transform ShootPos;
//    public float Force;
//    private Animator crep;


//    /// <summary>
//    /// Value of bullet speed
//    /// </summary>
//    public float Speed;
//    /// <summary>
//    /// value of vector 2 of target position
//    /// </summary>
//    private Transform TargetPosition;
//    /// <summary>
//    /// value of the distance of bulllet
//    /// </summary>
//    public bool IsMoving;
//    public float Move;
//    public float Attack;
//    bool IsShooting = false;
//    //public float UnattackDistance; // new variable to define attack range
//    // new variable to define attack range

//    // Start is called before the first frame update
//    void Start()
//    {
//        crep = GetComponent<Animator>();
//        TargetPosition = GameObject.FindGameObjectWithTag("Player").transform;
//        IsMoving = true;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float distance = Vector3.Distance(transform.position, TargetPosition.position); // vi tri cua nhan vat va crep
//        if (distance <= Move) // check if distance is less than or equal to Move
//        {
//            if (IsMoving && Attack <= distance)
//            {
//                transform.position = Vector2.MoveTowards(transform.position, TargetPosition.position, Speed * Time.deltaTime);
//                crep.SetBool("Crep", true);
//            }

//            if (distance <= Attack)
//            {

//                if (Time.time > nextTimeToFire)
//                {
//                    nextTimeToFire = Time.time + 1 / FireRate;
//                    shoot();
//                    crep.SetBool("Crep", false);
//                }
//            }
//            else
//            {
//                IsMoving = true;
//            }
//        }
//    }

//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.gameObject.CompareTag("Bullet") || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Grenade"))
//        {
//            this.gameObject.SetActive(false);
//        }
//    }
//    //private void OnTriggerEnter2D(Collider2D collision)
//    //{
//    //    if (collision.gameObject.CompareTag("Grenade"))
//    //    {
//    //        Physics2D.IgnoreCollision(collision.GetComponent<Collider2D>(), GetComponent<Collider2D>());
//    //        gameObject.SetActive(false);
//    //    }
//    //}




//    void shoot()
//    {
//        GameObject BulletIns = Instantiate(Bullet, ShootPos.position, Quaternion.identity);
//        Vector2 direction = (TargetPosition.position - ShootPos.position).normalized;
//        BulletIns.GetComponent<Rigidbody2D>().AddForce(direction * Force);
//    }
//}
