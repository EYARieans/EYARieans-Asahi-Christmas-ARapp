using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonalizedMsg : MonoBehaviour
{

    public InputField userName;
    public Text personalText;
     

    public void displayCustomName()
    {

        // string Name = userName.
        personalText.text = "Hi " + userName.text;
        print("personal msg" + personalText.text);
        userName.text = "";

    }
   

}
