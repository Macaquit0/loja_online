using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LojinhaOnline
{
    public class PaymentPanel : MonoBehaviour
    {
        private UIManager uiManager;
        private BagPanel bagPanel;
        public TransactionRequest request;
        public FakeBank bank;
        public InputField cardNumber;
        public InputField cardName;
        public InputField cardVal;
        public InputField cardCvv;
        public Text totalPriceTxt;
        public Text totalPriceTxt2;
        public GameObject incorrectTextObj;
        public GameObject incorrectTextObj2;
        public GameObject incorrectTextObj3;
        public GameObject incorrectTextObj4;

        public int storeID;
        
        void Start()
        {            
            uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
            bagPanel = GameObject.Find("Sacola").GetComponent<BagPanel>();
        }

        // Update is called once per frame
        void Update()
        {
            if (totalPriceTxt != null);
            totalPriceTxt.text = bagPanel.total.ToString("0.00");
            storeID = bagPanel.products[0].store;
        }
        public void ConfirmPurchase()
        {
            incorrectTextObj.SetActive(false);
            incorrectTextObj2.SetActive(false);
            incorrectTextObj3.SetActive(false);
            incorrectTextObj4.SetActive(false);

            if(cardNumber.text.Length < 4)
            {
                incorrectTextObj.SetActive(true);
            }              
            if(cardName.text == "")
            {
                incorrectTextObj2.SetActive(true);
            }            
            if(cardVal.text == "")
            {
                incorrectTextObj3.SetActive(true);
            }            
            if(cardCvv.text == "")
            {
                incorrectTextObj4.SetActive(true);
            }
            if (cardNumber.text.Length >= 4 && cardName.text != "" && cardVal.text != "" && cardCvv.text != "")
            {
                request.cardNumber = cardNumber.text;
                if (bank.Pay(request))
                {
                    bagPanel.ResetBag();
                    uiManager.ConfirmPurchase(storeID);
                    totalPriceTxt2.text = bagPanel.total.ToString("0.00");
                }
                else
                {
                    incorrectTextObj.SetActive(true);
                }

            }
        }
    }
}

