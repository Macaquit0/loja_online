using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LojinhaOnline 
{

    public class ProductPanel : MonoBehaviour
    {
        private UIManager uiManager;
        public ProductSlot slot;
        public BagPanel bag;
        public Image banner;
        public Text quantitySlctTxt;
        public int quantitySlct;
        public Text buyCost;
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            float finalCost = slot.cost * quantitySlct;
            buyCost.text = finalCost.ToString("0.00");
            quantitySlctTxt.text = quantitySlct.ToString(); 
        }
        public void IncreaseQuantity()
        {   
            if (quantitySlct < slot.availableQtt)
            quantitySlct++;
        }        
        public void DecreaseQuantity()
        {
            if (quantitySlct > 1)
            quantitySlct--;
        }
        public void OnClickAdd()
        {   
            Debug.Log(this.slot);
            uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
            uiManager.BagViewOn();
            bag.AddToBag(this.slot, quantitySlct);
            if (slot.availableQtt < 1)
            {
                quantitySlct = 0;
            }
            else
            {
                quantitySlct = 1;
            }
            quantitySlctTxt.text = quantitySlct.ToString();
        }
    }
}
