using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EfeitoDigitador : MonoBehaviour
{
   private TextMeshProUGUI componenteTexto;
   private AudioSource _audioSource;
   private string mensagemOriginal;
   public bool imprimindo;

   private void Awake(){
      TryGetComponent(out componenteTexto);
      TryGetComponent(out _audioSource);
      mensagemOriginal = componenteTexto.text;
      componenteTexto.text = "";
   }

   private void OnEnable(){

   }

   private void OnDisable(){
      componenteTexto.text = mensagemOriginal;
   }

   public void ImprimirMensagem(string mensagem){

   }

   IEnumerador LetraPorLetra(string mensagem){
      string msg = "";
      foreach (var lertra in mensagem){
         msg += letra;
         componenteTexto.text = msg;
         _audioSource.Play();
         yield return new WaitForSconds(0.7);
      }
   }
}
