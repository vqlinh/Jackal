//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CrepShoot : MonoBehaviour
//{

//    public Transform FireposX;
//    public GameObject Grenade;
//    public float TimeFire = 0.2f;

//    private float timeFire;
//    public float GrenadeForce;
//    public SpriteRenderer CharacterSR;



//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        timeFire -= Time.deltaTime;

//        if (timeFire < 0)
//        {
//            FireGrenade();
//        }

//    }
//    void FireGrenade()
//    {
//        timeFire = TimeFire;
//        GameObject GrenadeTMP = Instantiate(Grenade, FireposX.position, Quaternion.identity);
//        Rigidbody2D rb = GrenadeTMP.GetComponent<Rigidbody2D>();
//        rb.AddForce(CharacterSR.transform.up * GrenadeForce, ForceMode2D.Impulse);

//    }
//}
