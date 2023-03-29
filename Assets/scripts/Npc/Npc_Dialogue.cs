using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_Dialogue : MonoBehaviour
{
    public float dialogueRange;
    public LayerMask playerLayer;

    public DialogueSettings dialogue;

    bool playerHit;

    private List<string> sentences = new List<string>();

    private void start()
    {
        GetNPCInfo();
    }


    //É chamado a cada frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& playerHit)
        {
            DialogueControl.instance.Speech(sentences.ToArray());   
            
        }   
    }
    
    void GetNPCInfo()
    {
        for(int i = 0; i < dialogue.dialogues.Count; i++)
        {
            sentences.Add(dialogue.dialogues[i].sentence.portuguese);
        }
    }

    //É usado pela física
    void FixedUpdate()
    {
        ShowDialogue();
    }

    void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer);

        if(hit != null)
        {
            playerHit = true;
        }
        else
        {
            playerHit = false;
            DialogueControl.instance.dialogueObj.SetActive(false);
        }
    }
     
        
        private void OnDrawGizmosSelected() 
        {
            Gizmos.DrawWireSphere(transform.position, dialogueRange);
        }
             
    
    }

