using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LojinhaOnline 
{
    public class ProductSlot : MonoBehaviour
    {
        public string name;
        public float cost = 0;
        public float delTax = 0;

        [TextArea(3, 5)]
        public string desc;
        public int availableQtt;
        public int selectedQtt;
        public int store;
        public Image icon;

        public Text nameTxt;
        public Text costTxt;
        public Text descTxt;

        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (availableQtt == 0)
            {
                this.gameObject.SetActive(false);
            }            
            else
            {
                this.gameObject.SetActive(true);
            }
        }
    }
}