using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;

public class Submit : MonoBehaviour
{
    public int population;
    public int no_of_matings;
    public GameObject populationInputField;
    public GameObject noOfMatingsInputField;




    public void getInputs()
    {
        try
        {
  
            population = int.Parse(populationInputField.GetComponent<Text>().text);
            no_of_matings = int.Parse(noOfMatingsInputField.GetComponent<Text>().text);
        }
        catch 
        {
            print("Wrong type entered!");
        }


        //Communicates with a flask server
        using (var client = new HttpClient())
        {
 
            var response = client.GetAsync($"http://localhost:5000/{population}&{no_of_matings}").Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;

                // by calling .Result you are synchronously reading the result
                string responseString = responseContent.ReadAsStringAsync().Result;

                print(responseString);
            }
        }

    }

}
