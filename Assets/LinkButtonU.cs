using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkButtonU : MonoBehaviour
{
   // public string linkldnUrl;
  // public string youtubeUrl;
   // public string playStoreUrl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenLinkldn()
    {
        Application.OpenURL("https://www.linkedin.com/in/mitu-k-90301a28/");
        Debug.Log("is thi working");

    }
  public void OpenLYoutube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC0Fh0NyChbuX8RJ54Vob6Fg");

    }
    public void OpenPlayStore()
    {
        Application.OpenURL("https://play.google.com/store/apps/developer?id=Mits+Lab");

    }
    public void CallOnPhn()
    {
       Application.OpenURL("tel://22455252525");

    }
   public void SendEmail()
    {
        string email = "mitu.choudhary28@gmail.com";
        string subject = MyEscapeURL("My AR Buissness Card");
        string body = MyEscapeURL("Hi,This is Mitu");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
}
