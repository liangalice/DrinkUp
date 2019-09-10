using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BottleFill_Load : MonoBehaviour
{

    int filler = 0;
    int counter = 0;
    [SerializeField] Text getText;
    int holder;
    [SerializeField] Text numberOfBottlesFilled;
    int useThisToStore;



    public void changeAccordingtoFill()
    {
        filler = int.Parse(getText.text);

        if (filler > 8) // more than 8 ounces = 1 bottle
        {

            holder = filler; // use holder to act as a variable to help load scene
            while (holder > 8)
            {
                counter++; // counter is the amount of bottles of 8 ounces
                holder = holder - 8;
            }
            //  useThisToStore += counter;
            //  PlayerPrefs.SetInt("bottlesDrank", useThisToStore);
            //   PlayerPrefs.SetInt("numberOfOunces", holder);

            if (holder <= 1)
            {
                SceneManager.LoadScene("FirstFill");
            }
            else if ((holder > 1) && holder <= (2))
            {
                SceneManager.LoadScene("SecondFill");
            }
            else if ((holder > 2) && holder <= (3))
            {
                SceneManager.LoadScene("ThirdFill");
            }
            else if ((holder > (3) && holder <= (4)))
            {
                SceneManager.LoadScene("FourthFill");
            }
            else if ((holder > (4) && holder <= (5)))
            {
                SceneManager.LoadScene("FifthFill");
            }
            else if ((holder > (5) && holder <= (6)))
            {
                SceneManager.LoadScene("SixthFill");
            }
            else if ((holder > (6) && holder <= (7)))
            {
                SceneManager.LoadScene("SeventhFill");
            }
            else if ((holder > (7) && holder <= (8)))
            {
                SceneManager.LoadScene("EighthFill");
            }
           
        
        }
      
        // setting the filler to how much bottles to add
 /*     if( filler == 8)
        {

         
            PlayerPrefs.SetInt("bottlesDrank", 1);
        }
        
        if (filler < 8)
        {
         
            PlayerPrefs.SetInt("numberOfOunces", filler);
        }
        ////// checking if ounces are >8 , if so add new bottle
        /// 
        if (PlayerPrefs.GetInt("numberOfOunces") > 8)
        {
           
            int holder = PlayerPrefs.GetInt("numberOfOunces");
            int holder2 = 0;
            while(holder > 8)
            {
                holder = holder - 8;
                holder2++;
            }
            PlayerPrefs.SetInt("bottlesDrank", PlayerPrefs.GetInt("bottlesDrank") + holder2);
            PlayerPrefs.SetInt("numberOfOunces", holder2);
        }
        */

        // less than a bottle of water

        else if (filler <= 1)
        {
            SceneManager.LoadScene("FirstFill");
        }
        else if ((filler > 1) && filler <= (2))
        {
            SceneManager.LoadScene("SecondFill");
        }
        else if ((filler > 2) && filler <= (3))
        {
            SceneManager.LoadScene("ThirdFill");
        }
        else if ((filler > (3) && filler <= (4)))
        {
            SceneManager.LoadScene("FourthFill");
        }
        else if ((filler > (4) && filler <= (5)))
        {
            SceneManager.LoadScene("FifthFill");
        }
        else if ((filler > (5) && filler <= (6)))
        {
            SceneManager.LoadScene("SixthFill");
        }
        else if ((filler > (6) && filler <= (7)))
        {
            SceneManager.LoadScene("SeventhFill");
        }
        else if ((filler > (7) && filler <= (8)))
        {
            SceneManager.LoadScene("EighthFill");
        }

      


    }

    }
