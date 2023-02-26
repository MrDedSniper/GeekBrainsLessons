using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ7 : MonoBehaviour
{
     public string textForDz;
     public int howMuchLetters;

     private void Start()
     {
          textForDz = "Зло – это зло, Стрегобор, – серьезно сказал ведьмак, вставая. – " +
                      "Меньшее, большее, среднее – все едино, пропорции условны, а границы размыты. " +
                      "Я не святой отшельник, не только одно добро творил в жизни. Но если приходится " +
                      "выбирать между одним злом и другим, я предпочитаю не выбирать вообще";
          Debug.Log(textForDz);

          howMuchLetters = textForDz.Length;
          Debug.Log("Количество букв в предложении: + " + howMuchLetters );
     }
     
     public static int CharCount(string str, char c)
     {
         int counter = 0;
         for (int i = 0; i < str.Length; i++)
         {
             if (str[i] == c)
                 counter++;
         }
         return counter;
     }
}
