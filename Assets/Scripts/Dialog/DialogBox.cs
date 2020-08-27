using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour
{
    //[SerializeField] public Text nameText;
    [SerializeField] public Text dialogText;

    [SerializeField] int lettersPerSecond;

    public event Action<bool> OnDialogOver;

    private Queue<string> queue;

    //public void setdialog(string dialog)
    //{
    //    dialogtext.text = dialog;
    //}
    void Start()
    {
        queue = new Queue<string>();
    }

    public IEnumerator TypeDialog(Dialog dialog)
    {
        queue.Clear();
        //enqueue all sentences
        foreach (string s in dialog.Sentences)
        {
            queue.Enqueue(s);
        }

        while (queue.Count > 0)
        {
            string sentence = queue.Dequeue();

            dialogText.text = "";
            foreach (var letter in sentence.ToCharArray())
            {
                dialogText.text += letter;
                yield return new WaitForSeconds(1f / lettersPerSecond);
            }
            OnDialogOver(false);
        }
    }


}
