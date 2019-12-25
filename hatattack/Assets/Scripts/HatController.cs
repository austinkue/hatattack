using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatController : MonoBehaviour
{
    public HatConfig hat;
    private Rigidbody2D rigid;

    private SpriteRenderer sprt;
    private Vector2 groundBound;

    private int durability;

    //initializes the rigidbody
    void initRigidBody()
    {
        rigid = this.GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(0, -hat.HatSpeed);
    }

    //initializes sprite renderer
    void initSpriteRenderer()
    {
        sprt = this.GetComponent<SpriteRenderer>();
    }

    void initGroundBound()
    {
        groundBound = new Vector2(0, -5.8f);
    }

    //returns true if hat hit the floor
    bool hatMissed()
    {
        if (transform.position.y < groundBound.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //stops hat if it hits the floor
    void stopHat()
    {
        if (hatMissed())
        {
            rigid.velocity = new Vector2(0, 0);
            StartCoroutine(Fade());
        }
    }

    //destroys hat
    void destroyHat()
    {
        Destroy(this.gameObject);
    }

    IEnumerator Fade()
    {
        for (float ft = 1f; ft >= 0; ft -= 0.05f)
        {
            Color c = sprt.color;
            c.a = ft;
            sprt.color = c;
            yield return null;
        }
        destroyHat();
    }

    // Start is called before the first frame update
    void Start()
    {
        initRigidBody();
        initGroundBound();
        initSpriteRenderer();
    }

    // Update is called once per frame
    void Update()
    {
        stopHat();
    }
}
