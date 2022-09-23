using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("square"))
        {
            onAnimator();
            gameManager.I.gameOver();
        }
    }

    public void onAnimator()
    {
        animator.SetTrigger("collide");
        Destroy(gameObject, 0.5f);
    }
}
