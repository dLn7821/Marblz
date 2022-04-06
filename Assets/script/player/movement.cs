using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementspeed;
    public Rigidbody2D rb;
    public Animator anim;
    public float x;
    public float y;
    public float a;
    private bool iswalking;
    private GameObject HitObject;
    private Vector3 moveDir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (x != 0 || y != 0)
        {
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);
            if (!iswalking)
            {
                iswalking = true;
                anim.SetBool("IsMoving", iswalking);
                StopMoving();
            }
        }
        else if (iswalking)
        {
            iswalking = false;
            anim.SetBool("IsMoving", iswalking);
        }
        moveDir = new Vector3(x, y).normalized;
        if (Input.GetMouseButton(0) && InventoryCanvas.isOpenedbag == false)
            if (Input.GetMouseButton(0) && InventoryCanvas.isOpenedinventory == false)
            {
                StartCoroutine(Attack());
            }



    }
    public IEnumerator Attack()
    {
        anim.SetBool("IsAttacking", true);

        yield return new WaitForSeconds(0.4f);
        anim.SetBool("IsAttacking", false);
    }
    private void FixedUpdate()
    {
        rb.velocity = moveDir * movementspeed * Time.deltaTime;
    }
    private void StopMoving()
    {
        rb.velocity = Vector3.zero;
    }

}
