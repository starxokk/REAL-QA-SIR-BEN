using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodSelector : MonoBehaviour
{
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
    }


}
