using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { FreeRoam, Interact, Memento, Recipe}

public class GameController : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] DialogBox dialogBox;
    //[SerializeField] MementoSystem mementoSystem;
    //[SerializeField] RecipeSystem recipeSystem;

    public event Action TalkOver;

    GameState state;

    private void Start()
    {
        //set dialog disabled
        dialogBox.enabled = false;

        //when OnEncountered event recieved, run StartInteraction()
        playerController.Talk += StartDialog;
        dialogBox.OnDialogOver += EndDialog;
    }

    private void Update()
    {
        if(state == GameState.FreeRoam)
        {
            playerController.HandleUpdate();
        }
        else if (state == GameState.Interact)
        {
        }
        else if (state == GameState.Memento)
        {

        }
        else if (state == GameState.Recipe)
        {

        }
    }

    void StartDialog(Dialog dialog)
    {
        dialogBox.enabled = true;
        state = GameState.Interact;
        dialogBox.gameObject.SetActive(true);
        StartCoroutine(dialogBox.TypeDialog(dialog));
    }

    void EndDialog(bool isEnded)
    {
        if(!isEnded)
        {
            dialogBox.enabled = false;
            state = GameState.FreeRoam;
            dialogBox.gameObject.SetActive(false);
        }
    }
}

