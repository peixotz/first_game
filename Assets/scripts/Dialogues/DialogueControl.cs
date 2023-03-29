using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{

    [Header("Components")]
    public GameObject dialogueObj; //Objeto janela do diálogo
    public Image profileSprite; //Foto do perfil
    public Text speechText; //Texto da fala
    public Text actorNameText; //Nome do NPC

    [Header("Settings")]
    public float typingSpeed; //Velocidade da fala

    //Variável de controle
    private bool isShowing; //Se a janela está visível.
    private int index; //index das sentenças(fala, texto, etc)
    private string[] sentences;

    
    public static DialogueControl instance;


    //Awake é chamado antes de todos os starts() na hierarquia de execução de scripts.
    private void Awake()
    {
        instance = this;
    }



    void Start()
    {   
        
    }

    
    void Update()
    {
        
    }

    IEnumerator TypeSentence()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }

    //Pular para a próxima frase/fala
    public void NextSentence()
    {

    }

    // Chamar a fala do NPC
    public void Speech(string[] txt)
    {
        if(!isShowing) //Verifica se é FALSE
        {
            dialogueObj.SetActive(true);
            sentences = txt;
            StartCoroutine(TypeSentence());
            isShowing = true;

        }
    }
}
