using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable_Day15
{
    public class Frequency
    {  
        public void count_frequency(string sentence)
        {
            Hashtable MyMapNode = new Hashtable();
            string[] arr = sentence.Split();

            for(int i = 0; i< arr.Length; i++)
            {
                if (MyMapNode.ContainsKey(arr[i]))
                {
                    MyMapNode[arr[i]] = (int)MyMapNode[arr[i]] + 1;
                }
                else
                {
                    MyMapNode.Add(arr[i], 1);
                }
            }
            foreach(DictionaryEntry element in MyMapNode)
            {
                Console.WriteLine(element.Key + " " + element.Value);
            }
        }
    }
}
