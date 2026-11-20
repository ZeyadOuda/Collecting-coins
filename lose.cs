using UnityEngine;
using UnityEngine.SceneManagement;
public class lose: MonoBeviour
{
    void Start()
    {
        
    }
    void Update ()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            sceneManager.LoadScene("SampleScene");
        }
    }    

}