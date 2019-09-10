using UnityEngine;
using UnityEngine.UI;


public class displayBottleDrank : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text displayText;
    int filler = 0;
    int bottleHolder = 0;
    [SerializeField] Text getText;

    /* void Start()
     {
         PlayerPrefs.SetInt("currNum", 0);
         PlayerPrefs.SetInt("currBottles", 0);
     }
     */
    public void convertOunceToBottle()
    {
        filler = int.Parse(getText.text);
        while (filler >= 8)
        {
            filler = filler - 8;
            bottleHolder++;
        }
        PlayerPrefs.SetInt("bottleHolder", bottleHolder);
        PlayerPrefs.SetInt("num", filler);

    }
    public void addToTotal()
    {
        PlayerPrefs.SetInt("currBottles", PlayerPrefs.GetInt("bottleHolder")+ PlayerPrefs.GetInt("currBottles"));
        PlayerPrefs.SetInt("currNum", PlayerPrefs.GetInt("num")+ PlayerPrefs.GetInt("currNum"));

        if (PlayerPrefs.GetInt("currNum") >= 8)
        {
            int use = PlayerPrefs.GetInt("currNum");
            int counter = 0;
            while (use >= 8)
            {
                use = use - 8;
                counter++;
            }
            PlayerPrefs.SetInt("currBottles", PlayerPrefs.GetInt("currBottles") + counter);
            PlayerPrefs.SetInt("currNum", use);
        }
    }






    public void Update()
    {
       

        displayText.text = "You have drank " + PlayerPrefs.GetInt("currBottles").ToString() + "bottles"+ " and "+PlayerPrefs.GetInt("currNum")+" ounces" ;
    }

}
