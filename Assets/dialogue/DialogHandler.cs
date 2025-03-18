using UnityEngine;
using UnityEngine.UI;

public class NPCDialogTrigger : MonoBehaviour
{
    public GameObject dialogCanvas; // Objek Canvas yang berisi dialog
    private bool playerInRange = false; // Apakah player berada dalam area NPC

    void Start()
    {
        dialogCanvas.SetActive(false); // Sembunyikan dialog saat awal permainan
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F)) // Jika di dekat NPC & tekan "F"
        {
            dialogCanvas.SetActive(true); // Tampilkan dialog
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Jika objek yang masuk ke trigger adalah "Player"
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Jika player keluar dari trigger
        {
            playerInRange = false;
            dialogCanvas.SetActive(false); // Sembunyikan dialog saat player pergi
        }
    }
}
