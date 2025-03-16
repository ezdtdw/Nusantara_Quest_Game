using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class DialogueKakekMuseum : MonoBehaviour
{
    private Transform player;
    private SpriteRenderer SpeechBubbleRenderer;


    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        SpeechBubbleRenderer = GetComponent<SpriteRenderer>();
        SpeechBubbleRenderer.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SpeechBubbleRenderer.enabled = true;
            //
            player = collision.gameObject.GetComponent<Transform>();
            //
            if(player.position.x > transform.position.x && transform.parent.localScale.x < 0) {
                Flip();
            } else if (player.position.x < transform.position.x && transform.parent.localScale.x > 0) {
                Flip();
            }
        }
    }
    private void Flip(){
        Vector3 currentScale = transform.parent.localScale;
        currentScale.x *= -1;
        transform.parent.localScale = currentScale;
    }
}
