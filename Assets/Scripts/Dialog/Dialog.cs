using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialog", menuName = "Dialog/Create new Dialog")]
public class Dialog : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] List<string> sentences;
    [SerializeField] bool isSelf;

    //properties
    public string Name
    {
        get { return name; }
    }

    public List<string> Sentences
    {
        get { return sentences; }
    }
}