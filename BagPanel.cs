using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LojinhaOnline
{
    public class BagPanel : MonoBehaviour
    {
        public UIManager uiManager;
        public ProductSlot[] products;
        public GameObject[] productsObjs;
        public StoreSlot[] storeslots;
        public int productsInBag = 0;
        public Image storeLogo;
        public Text storeName;
        public Text subTotalTxt;
        public Text delTaxTxt;
        public Text delTaxTxt2;
        public Text totalTxt;        
        public Text qtt1Txt;        
        public Text qtt2Txt;        
        public Text qtt3Txt;        
        public float subTotal;
        public float delTax;
        public float total;
        public float selectedQtt1;
        public float selectedQtt2;
        public float selectedQtt3;
        public GameObject storeObj;
        public GameObject deliveryObj;
        public GameObject confirmBtnObj;

        void Start()
        {
            productsInBag = 0;
            uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if (products[0])
            subTotal = products[0].cost + products[1].cost + products[2].cost;
            subTotalTxt.text = subTotal.ToString("0.00");            
                        
            total = subTotal + delTax;
            totalTxt.text = total.ToString("0.00");
        }
        public void AddToBag(ProductSlot slot, int selectedQtt)
        {
            delTax = slot.delTax;
            delTaxTxt.text = delTax.ToString("0.00");
            delTaxTxt2.text = delTax.ToString("0.00");
            confirmBtnObj.SetActive(true);
            if (slot.store == 0)
            {
                storeObj.SetActive(true);
                deliveryObj.SetActive(true);
                storeLogo.sprite = storeslots[0].icon.sprite;
                storeName.text = storeslots[0].name.text;
            }            
            else if (slot.store == 1)
            {
                storeObj.SetActive(true);
                deliveryObj.SetActive(true);
                storeLogo.sprite = storeslots[1].icon.sprite;
                storeName.text = storeslots[1].name.text;
            }
            if (productsInBag == 0)
            {
                productsObjs[0].SetActive(true);
                products[0].name = slot.name;
                products[0].cost = slot.cost * selectedQtt;
                products[0].desc = slot.desc;
                products[0].availableQtt = slot.availableQtt;
                products[0].nameTxt.text = slot.name;
                products[0].costTxt.text = products[0].cost.ToString("0.00");
                products[0].descTxt.text = slot.desc;
                products[0].icon.sprite = slot.icon.sprite;
                products[0].selectedQtt = selectedQtt;
                slot.availableQtt -= selectedQtt;
                productsInBag++;
                qtt1Txt.text = products[0].selectedQtt.ToString();
                return;
            }              
            else if (productsInBag == 1 && products[0].name != slot.name)
            {
                productsObjs[1].SetActive(true);
                products[1].name = slot.name;
                products[1].cost = slot.cost * selectedQtt;
                products[1].desc = slot.desc;
                products[1].availableQtt = slot.availableQtt;
                products[1].nameTxt.text = slot.name;
                products[1].costTxt.text = products[1].cost.ToString("0.00");
                products[1].descTxt.text = slot.desc;
                products[1].icon.sprite = slot.icon.sprite;
                products[1].selectedQtt = selectedQtt;
                slot.availableQtt -= selectedQtt;
                productsInBag++;
                qtt2Txt.text = products[1].selectedQtt.ToString();
                return;
            }             
            else if (productsInBag == 2 && products[1].name != slot.name && products[0].name != slot.name)
            {
                productsObjs[2].SetActive(true);
                products[2].name = slot.name;
                products[2].cost = slot.cost * selectedQtt;
                products[2].desc = slot.desc;
                products[2].availableQtt = slot.availableQtt;
                products[2].nameTxt.text = slot.name;
                products[2].costTxt.text = products[2].cost.ToString("0.00");
                products[2].descTxt.text = slot.desc;
                products[2].icon.sprite = slot.icon.sprite;
                products[2].selectedQtt = selectedQtt;
                slot.availableQtt -= selectedQtt;
                productsInBag++;
                qtt3Txt.text = products[2].selectedQtt.ToString();
                return;
            }
            else if (productsInBag == 1 || productsInBag == 2 || productsInBag == 3)
            {
                if (products[0].name == slot.name)
                {
                    products[0].selectedQtt += selectedQtt;
                    products[0].cost += selectedQtt * slot.cost;
                    products[0].costTxt.text = products[0].cost.ToString("0.00");
                    qtt1Txt.text = products[0].selectedQtt.ToString();
                    slot.availableQtt -= selectedQtt;
                }                
                else if (products[1].name == slot.name)
                {
                    products[1].selectedQtt += selectedQtt;
                    products[1].cost += selectedQtt * slot.cost;
                    products[1].costTxt.text = products[1].cost.ToString("0.00");
                    qtt2Txt.text = products[1].selectedQtt.ToString();
                    slot.availableQtt -= selectedQtt;
                }                
                else if (products[2].name == slot.name)
                {
                    products[2].selectedQtt += selectedQtt;
                    products[2].cost += selectedQtt * slot.cost;
                    products[2].costTxt.text = products[2].cost.ToString("0.00");
                    qtt3Txt.text = products[2].selectedQtt.ToString();
                    slot.availableQtt -= selectedQtt;
                }
            }       
        }
        public void GoPay()
        {
            uiManager.PaymentViewOn();
        }
        public void ResetBag()
        {
            for (int i =0; i < 2; i++)
            {
                productsObjs[i].SetActive(true);
                products[i].name = "";
                products[i].cost = 0;
                products[i].desc = "";
                products[i].availableQtt = 0;
                products[i].nameTxt.text = "";
                products[i].costTxt.text = "";
                products[i].descTxt.text = "";
                products[i].icon.sprite = null;
                products[i].selectedQtt = 1;
                productsInBag = 0;
                qtt1Txt.text = products[i].selectedQtt.ToString();
            }     
        }
    }
}

