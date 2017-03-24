namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using System.Collections;

    public class showDialog : VRTK_InteractableObject
    {
        public override void StartUsing(GameObject usingObject)
        {
            /* Renderer dialogRenderer = gameObject.GetComponentInChildren<Renderer>();
             dialogRenderer.enabled = true;
             */

            //AudioSource audioLog = gameObject.GetComponent<AudioSource>();

           // audioLog.Play();

            GameObject dialog = this.transform.Find("ObjectDataUI").gameObject;

            bool dialogState = dialog.activeSelf;
            if (dialogState)
            {
                dialog.SetActive(false);
            } else
            {
                dialog.SetActive(true);
            }

           

            Debug.Log("Show dialog");
            
        }

        public override void StopUsing(GameObject usingObject)
        {
            
        }

        protected void Start()
        {
            
        }

        protected override void Update()
        {
          
        }
    }
}