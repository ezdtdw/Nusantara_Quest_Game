using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public Text dialogText; // Objek UI Text untuk menampilkan dialog
    public string[] dialogLines; // Array untuk menyimpan teks dialog
    private int currentLineIndex = 0; // Indeks baris dialog yang sedang ditampilkan

    void Start()
    {
        if (dialogLines.Length > 0)
        {
            ShowDialog();
        }
    }

    public void ShowDialog()
    {
        dialogText.text = dialogLines[currentLineIndex];
    }

    public void NextDialog()
    {
        if (currentLineIndex < dialogLines.Length - 1)
        {
            currentLineIndex++;
            ShowDialog();
        }
        else
        {
            gameObject.SetActive(false); // Sembunyikan dialog jika sudah habis
        }
    }
}