using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace MiCasa
{

    public class Section
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Room
    {
        public string name { get; set; }
        public int id { get; set; }
        public int section { get; set; }
    }

    public class Scene
    {
        public int active { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public int room { get; set; }
        public int? state { get; set; }
        public string comment { get; set; }
    }

    public class Device
    {
        public string name { get; set; }
        public string altid { get; set; }
        public int id { get; set; }
        public int category { get; set; }
        public int subcategory { get; set; }
        public int room { get; set; }
        public int parent { get; set; }
        public string ip { get; set; }
        public string light { get; set; }
        public string temperature { get; set; }
        public string status { get; set; }
        public string commFailure { get; set; }
        public string tripped { get; set; }
        public string armedtripped { get; set; }
        public string lasttrip { get; set; }
        public string armed { get; set; }
        public string watts { get; set; }
        public string kwh { get; set; }
        public int? state { get; set; }
        public string comment { get; set; }
        public string url { get; set; }
        public string commands { get; set; }
        public string level { get; set; }
        public string pulse { get; set; }
        public string pincodes { get; set; }
        public string locked { get; set; }
        public string batterylevel { get; set; }
        public string online { get; set; }
        public string transportstate { get; set; }
        public string currentplaymode { get; set; }
        public string currentstatus { get; set; }
        public string currenttitle { get; set; }
        public string currentartist { get; set; }
        public string currentalbum { get; set; }
        public string currentalbumart { get; set; }
        public string volume { get; set; }
        public string mute { get; set; }
        public string text1 { get; set; }
        public string text2 { get; set; }
        public string fanmode { get; set; }
        public string mode { get; set; }
        public string setpoint { get; set; }
        public string heat { get; set; }
        public string cool { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class RootObject
    {
        public int full { get; set; }
        public string version { get; set; }
        public string model { get; set; }
        public int zwave_heal { get; set; }
        public string temperature { get; set; }
        public string skin { get; set; }
        public string serial_number { get; set; }
        public string fwd1 { get; set; }
        public string fwd2 { get; set; }
        public int mode { get; set; }
        public List<Section> sections { get; set; }
        public List<Room> rooms { get; set; }
        public List<Scene> scenes { get; set; }
        public List<Device> devices { get; set; }
        public List<Category> categories { get; set; }
        public int ir { get; set; }
        public string irtx { get; set; }
        public int loadtime { get; set; }
        public int dataversion { get; set; }
        public int state { get; set; }
        public string comment { get; set; }
    }
}