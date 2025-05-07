using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class FoodSelector : MonoBehaviour
{
    public TextMeshProUGUI items_ordered;
    public GameObject cartpage;
    public GameObject orderpage;

    private float st;
    public void ST_value(float amount) { st = amount; }

    private float CPT;
    public void CPT_value(float amount) { CPT = amount; }

    private float smt;
    public void SMT_value(float amount) { smt = amount; }

    private float BBT;
    public void BBT_value(float amount) { BBT = amount; }


    public string selectedItem = "";

    public void SelectFood(string foodName)
    {
        selectedItem = foodName;
    }

    public void AddToCartAndGoToCartScene()
    {
        cartpage.SetActive(true);
        orderpage.SetActive(false);

        items_ordered.text = "Santorini Tomato: " + st + "\nCherokee Purple Tomato: " + CPT + "\nSan Marzano Tomato: " + smt + "\nBetter Boy Tomato: " + BBT + "\n";

    }

    public void GoBack()
    {
        cartpage.SetActive(false);
        orderpage.SetActive(true);
    }

    public void Reset_st()
    {
        st = 0;
        items_ordered.text = "Santorini Tomato: " + st + "\nCherokee Purple Tomato: " + CPT + "\nSan Marzano Tomato: " + smt + "\nBetter Boy Tomato: " + BBT + "\n";
    }
    public void Reset_CPT()
    {
        CPT = 0;
        items_ordered.text = "Santorini Tomato: " + st + "\nCherokee Purple Tomato: " + CPT + "\nSan Marzano Tomato: " + smt + "\nBetter Boy Tomato: " + BBT + "\n";
    }
    public void Reset_smt()
    {
        smt = 0;
        items_ordered.text = "Santorini Tomato: " + st + "\nCherokee Purple Tomato: " + CPT + "\nSan Marzano Tomato: " + smt + "\nBetter Boy Tomato: " + BBT + "\n";
    }
    public void Reset_BBT()
    {
        BBT = 0;
        items_ordered.text = "Santorini Tomato: " + st + "\nCherokee Purple Tomato: " + CPT + "\nSan Marzano Tomato: " + smt + "\nBetter Boy Tomato: " + BBT + "\n";
    }

}
