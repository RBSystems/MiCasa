namespace MiCasa;
        // class declarations
         class MiCasaWorker;
         class Section;
         class Room;
         class Scene;
         class Device;
         class Category;
         class RootObject;
     class MiCasaWorker 
    {
        // class delegates
        delegate FUNCTION errorHandler ( SIMPLSHARPSTRING errMsg );

        // class events

        // class functions
        FUNCTION PollData ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING myIPAddress[];
        SIGNED_LONG_INTEGER port;

        // class properties
        DelegateProperty errorHandler OnError;
    };

     class Section 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING name[];
        SIGNED_LONG_INTEGER id;
    };

     class Room 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING name[];
        SIGNED_LONG_INTEGER id;
        SIGNED_LONG_INTEGER section;
    };

     class Scene 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER active;
        STRING name[];
        SIGNED_LONG_INTEGER id;
        SIGNED_LONG_INTEGER room;
        STRING comment[];
    };

     class Device 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING name[];
        STRING altid[];
        SIGNED_LONG_INTEGER id;
        SIGNED_LONG_INTEGER category;
        SIGNED_LONG_INTEGER subcategory;
        SIGNED_LONG_INTEGER room;
        SIGNED_LONG_INTEGER parent;
        STRING ip[];
        STRING light[];
        STRING temperature[];
        STRING status[];
        STRING commFailure[];
        STRING tripped[];
        STRING armedtripped[];
        STRING lasttrip[];
        STRING armed[];
        STRING watts[];
        STRING kwh[];
        STRING comment[];
        STRING url[];
        STRING commands[];
        STRING level[];
        STRING pulse[];
        STRING pincodes[];
        STRING locked[];
        STRING batterylevel[];
        STRING online[];
        STRING transportstate[];
        STRING currentplaymode[];
        STRING currentstatus[];
        STRING currenttitle[];
        STRING currentartist[];
        STRING currentalbum[];
        STRING currentalbumart[];
        STRING volume[];
        STRING mute[];
        STRING text1[];
        STRING text2[];
        STRING fanmode[];
        STRING mode[];
        STRING setpoint[];
        STRING heat[];
        STRING cool[];
    };

     class Category 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING name[];
        SIGNED_LONG_INTEGER id;
    };

     class RootObject 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER full;
        STRING version[];
        STRING model[];
        SIGNED_LONG_INTEGER zwave_heal;
        STRING temperature[];
        STRING skin[];
        STRING serial_number[];
        STRING fwd1[];
        STRING fwd2[];
        SIGNED_LONG_INTEGER mode;
        SIGNED_LONG_INTEGER ir;
        STRING irtx[];
        SIGNED_LONG_INTEGER loadtime;
        SIGNED_LONG_INTEGER dataversion;
        SIGNED_LONG_INTEGER state;
        STRING comment[];
    };

