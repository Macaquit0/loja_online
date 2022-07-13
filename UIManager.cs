using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace LojinhaOnline
{
    public class UIManager : MonoBehaviour
    {
        //Itens de UI
        public Image logoLoja;
        public InputField endereco;
        public ScrollRect filtrosEstab;

        //GameObjects dos itens de UI
        public GameObject logoLojaObj;
        public GameObject enderecoObj;
        public GameObject filtrosEstabObj;
        public GameObject restViewObj;
        public GameObject mercViewObj;
        public GameObject bebViewObj;
        public GameObject storeViewObj;
        public GameObject storeViewObj2;
        public GameObject productViewObj;
        public GameObject productViewObj2;
        public GameObject productViewObj3;
        public GameObject productViewObj4;
        public GameObject productViewObj5;
        public GameObject bagViewObj;
        public GameObject payViewObj;
        public GameObject pedViewObj;
        public GameObject[] storeListOrderView;
        public GameObject orderBtn;
        
        //Animações
        public Animator anim;

        //Variaveis de apoio
        public int storeIndex;


        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        public void MercListOn()
        {
            anim.SetBool("Merc", true);
            anim.SetBool("Rest", false);
            anim.SetBool("Beb", false);
            mercViewObj.SetActive(true);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
        }        
        public void RestListOn()
        {
            anim.SetBool("Merc", false);
            anim.SetBool("Rest", true);
            anim.SetBool("Beb", false);
            mercViewObj.SetActive(false);
            restViewObj.SetActive(true);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
        }        
        public void BebListOn()
        {
            anim.SetBool("Merc", false);
            anim.SetBool("Rest", false);
            anim.SetBool("Beb", true);
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(true);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
        }
        public void BackToHome()
        {
            anim.SetBool("Merc", false);
            anim.SetBool("Rest", true);
            anim.SetBool("Beb", false);
            mercViewObj.SetActive(false);
            restViewObj.SetActive(true);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
            pedViewObj.SetActive(false);
        }
        public void StoreViewOn()
        {
            storeIndex = 0;
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(true);
            storeViewObj2.SetActive(false);   
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
        }        
        public void StoreViewOn2()
        {
            storeIndex = 1;
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(true);   
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
        }
        public void ProductViewOn()
        {
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);   
            productViewObj.SetActive(true);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false); 
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);       
        }        
        public void ProductViewOn2()
        {
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);   
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(true);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);         
        }        
        public void ProductViewOn3()
        {
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);   
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);         
            productViewObj3.SetActive(true);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
        }
        public void BackToStore()
        {
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(true);
            storeViewObj2.SetActive(false);   
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
        }
        public void ProductViewOn4()
        {
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);   
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);        
            productViewObj4.SetActive(true);        
            productViewObj5.SetActive(false);        
        }        
        public void ProductViewOn5()
        {
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(false);   
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);   
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(true);      
        }  
        public void BackToStore2()
        {
            mercViewObj.SetActive(false);
            restViewObj.SetActive(false);
            bebViewObj.SetActive(false);
            storeViewObj.SetActive(false);
            storeViewObj2.SetActive(true);   
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);  
        }
        public void BagViewOn()
        {
            bagViewObj.SetActive(true);
            anim.SetBool("Bag", true);
            if (storeIndex == 0)
            {
                storeViewObj.SetActive(true);
                storeViewObj2.SetActive(false);
            }            
            else if (storeIndex == 1)
            {
                storeViewObj.SetActive(false);
                storeViewObj2.SetActive(true);
            }
            productViewObj.SetActive(false);         
            productViewObj2.SetActive(false);
            productViewObj3.SetActive(false);
            productViewObj4.SetActive(false);        
            productViewObj5.SetActive(false);
        }        
        public void BagViewOff()
        {
            anim.SetBool("Bag", false);
            //BagViewObj.SetActive(false);
        }
        public void PaymentViewOn()
        {
            payViewObj.SetActive(true);
        }        
        public void BackToBag()
        {
            payViewObj.SetActive(false);
            bagViewObj.SetActive(true);
        }

        public void ConfirmPurchase(int storeID)
        {
            anim.SetBool("Bag", false);
            pedViewObj.SetActive(true);
            payViewObj.SetActive(false);
            bagViewObj.SetActive(false);
            orderBtn.SetActive(true);
            storeListOrderView[storeID].SetActive(true);
        }
        public void OpenOrder()
        {
            pedViewObj.SetActive(true);
        }
    }
}

