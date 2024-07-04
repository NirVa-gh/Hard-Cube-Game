using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;
namespace Button
{
    public class ButtonPanel : MonoBehaviour
    {
        protected bool m_IsShowing;
        protected CanvasGroup m_CanvasGroup;
        
        private void Start()
        {
            m_CanvasGroup = GetComponent<CanvasGroup>();
        }
        public void Open()
        {
            
        }
        public void Close()
        {

        }
        private void Hide()
        {

            if (m_IsShowing)
            {
                return;
            }
            this.m_IsShowing = true;
            gameObject.SetActive (false);

            m_CanvasGroup.alpha = 0;
            m_CanvasGroup.interactable = false;
            m_CanvasGroup.blocksRaycasts = false;
        }
        private void Show()
        {
            if (!m_IsShowing)
            {
                return;
            }
            this.m_IsShowing = false;
            gameObject.SetActive (true);

            m_CanvasGroup.alpha = 1;
            m_CanvasGroup.interactable = true;
            m_CanvasGroup.blocksRaycasts = true;
 
        }
        public static void PlaySound(AudioClip clip, float volume)
        {

        }


        


    }
}

