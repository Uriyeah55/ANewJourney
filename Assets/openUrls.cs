using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openUrls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openTherapyGoogleLink(){
                Application.OpenURL("https://www.google.com/search?q=where+is+my+nearest+therapist&oq=where&gs_lcrp=EgZjaHJvbWUqCAgAEEUYJxg7MggIABBFGCcYOzIMCAEQABhDGIAEGIoFMgYIAhBFGDsyDAgDEAAYQxiABBiKBTIMCAQQABhDGIAEGIoFMgYIBRBFGDwyBggGEEUYPTIGCAcQRRg90gEINDA2OGowajeoAgCwAgA&sourceid=chrome&ie=UTF-8");
    }
        public void openYTComf(){
            Application.OpenURL(" https://www.youtube.com/results?search_query=comfy+playlists");
    }
}