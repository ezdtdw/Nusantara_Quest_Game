using UnityEngine;

public class DialogueKakekMuseum : MonoBehaviour
{
    private Transform player;
    private SpriteRenderer SpeechBubbleRenderer;

    void Start()
    {
        SpeechBubbleRenderer = GetComponent<SpriteRenderer>();
        SpeechBubbleRenderer.enabled = false; // Awalnya tidak terlihat
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SpeechBubbleRenderer.enabled = true; // Munculkan icon
            player = collision.gameObject.transform; // Ambil posisi player
            
            // NPC akan flip jika player ada di sisi yang berlawanan
            if (player.position.x > transform.position.x && transform.parent.localScale.x < 0) 
            {
                Flip();
            } 
            else if (player.position.x < transform.position.x && transform.parent.localScale.x > 0) 
            {
                Flip();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SpeechBubbleRenderer.enabled = false; // Sembunyikan icon saat player keluar
        }
    }

    private void Flip()
    {
        Vector3 currentScale = transform.parent.localScale;
        currentScale.x *= -1;
        transform.parent.localScale = currentScale;
    }
}