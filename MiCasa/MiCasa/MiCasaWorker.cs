using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Crestron.SimplSharp;  // For Basic SIMPL# Classes
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using Crestron.SimplSharp.Net.Http;
using Crestron.SimplSharp.Net;
using Crestron.SimplSharp.CrestronIO;
using Crestron.SimplSharp.CrestronWebSocketClient;

using System.Collections;



namespace MiCasa
{
    public class MiCasaWorker
    {
        public String myIPAddress = "skaanvik.viewcam.me";//"192.168.52.100";
        public int port = 3480;
        String baseURL;
        HttpClient myHttpClient = null;
        // Public delegates
        public errorHandler OnError { get; set; } 
        public delegate void errorHandler(SimplSharpString errMsg);

        public MiCasaWorker()
        {
            myHttpClient = new HttpClient();
            myHttpClient.TimeoutEnabled = true;
            myHttpClient.Timeout = 5;
            myHttpClient.KeepAlive = false;
        }

        public void PollData()

        {
            baseURL = "http://" + myIPAddress + ":" + port + "/data_request?id=sdata";
            myHttpClient.Url.Parse(baseURL);
            try
            {
                if (!myHttpClient.ProcessBusy)
                {
                    HttpClientRequest myHttpRequest = new HttpClientRequest();
                    myHttpRequest.Url.Parse(baseURL);
                    myHttpRequest.RequestType = RequestType.Get;
                    HttpClientResponse myHttpResponse = myHttpClient.Dispatch(myHttpRequest);
                    //CrestronConsole.PrintLine(myHttpResponse.ContentString);
                    RootObject jobj = JsonConvert.DeserializeObject<RootObject>(myHttpResponse.ContentString);
                    myHttpClient.Abort();
                    
                    CrestronConsole.PrintLine("Database:" + jobj.dataversion);
                    /*foreach (var item in jobj.rooms)
                    {
                        CrestronConsole.PrintLine("Room:{0}, Name:{1} Section:{2}", item.id,item.name,item.section);
                    }
                    foreach (var ItemScene in jobj.scenes)
                    {
                        CrestronConsole.PrintLine("SceneName:{0}, ID:{1} Active:{2} RoomNr:{3}", ItemScene.name,ItemScene.id,ItemScene.active,ItemScene.room);
                    }
                     
                    foreach (var ItemCategories in jobj.categories)
                    {
                        CrestronConsole.PrintLine("CatName:{0}, ID:{1}", ItemCategories.name,ItemCategories.id);
                    }
                   
                    foreach (var ItemDevice in jobj.devices.Where(ItemDevice => ItemDevice.category == 17))
                    {
                        CrestronConsole.PrintLine("Temerature:{0} RoomID:{1}", ItemDevice.temperature,ItemDevice.room);
                    }
                     foreach (var ItemDevice in jobj.devices.Where(ItemDevice => ItemDevice.category == 18))
                     {
                         CrestronConsole.PrintLine("Lights:{0} RoomID:{1}", ItemDevice.light, ItemDevice.room);
                     }
                    */
                      foreach (var ItemDevice in jobj.devices.Where(ItemDevice => ItemDevice.category == 3))
                    {
                        CrestronConsole.PrintLine("Rom:{2} Name:{0} Status:{1} Watts:{3}", ItemDevice.name, ItemDevice.status,ItemDevice.room, ItemDevice.watts);
                    }
                    //CrestronConsole.PrintLine(" Xx:-)");
                    
                }
                else
                {
                    CrestronConsole.PrintLine("ProcessBusy!");
                }
            }

            catch (Exception ex)
            {
                myHttpClient.Abort();
                CrestronConsole.PrintLine("Error sending commandX: {0} ", ex.Message);
                if (OnError != null)
                    OnError(new SimplSharpString(ex.ToString() + "\new\ref" + ex.StackTrace));
            }
        }
    }
}
