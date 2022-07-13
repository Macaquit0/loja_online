using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LojinhaOnline 
{
    public class FakeBank : MonoBehaviour
    {
        public bool Pay (TransactionRequest request)
        {
            string s1 = request.cardNumber;
            string s2 = s1.Substring(s1.Length - 4);

            if (s2 == "1234")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}