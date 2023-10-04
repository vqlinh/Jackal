using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nhadanphai : MonoBehaviour
{
    private Animator nhadan;
    public Enemyphai enemyphai;

    // Start is called before the first frame update
    void Start()
    {
        nhadan = GetComponent<Animator>();
        nhadan.SetBool("no", false);


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grenade")
        {
            //this.gameObject.SetActive(false);
            nhadan.SetBool("no", true);
            enemyphai.Show();


        }
    }
}
