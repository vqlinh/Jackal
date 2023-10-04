using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnmNade : MonoBehaviour
{
    private Animator Grenade;
    private Rigidbody2D rb;
    private bool isFlying = false; // Khởi tạo biến kiểm tra grenade đã được phóng lên hay chưa


    void Update()
    {
        if (Input.GetKey((KeyCode)'x'))
        {
            //Grenade.SetBool("fly", true);
            isFlying = true; // Đánh dấu grenade đã được phóng lên
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (/*collision.gameObject.CompareTag("Gate") ||*/ isFlying)
        {
            Grenade.SetBool("bum", true);
        }
    }
    private IEnumerator ExplodeAfterDelay()
    {
        yield return new WaitForSeconds(0.8f);
        rb.velocity = Vector2.zero;
        IsExplosion();
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }

    private void Awake()
    {
        Grenade = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(ExplodeAfterDelay());
        Grenade.SetBool("fly", false);
    }
    public void IsExplosion()
    {
        Grenade.SetBool("bum", true);

    }

}