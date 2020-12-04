using System;

namespace bet365DataSDK.config
{
    public class Constant
    {
        // ------------------- base config start -------------------
        static string version = "v0";
        static string BASE_URL = String.Format("http://api.bet365data.com/bet365/{0}/api/", version);

        // ACCESS_TOKEN please contact https://github.com/BET365-API/BET365-API#contact; free trial for 7days!!!!
        public const string ACCESS_TOKEN = "";

        //  ------------------- base config end -------------------



        //  -------------------api interface start -------------------
        static string[] ApiList = { "FullTimeFullWin", "AsianHandiCap", "MatchGoal", "OverUnder" };

        //FullTimeFullWin
        public static string FullTimeFullWin_API = String.Concat(BASE_URL,ApiList[0]);

        // AsianHandiCap
        public static string AsianHandiCap_API = String.Format(BASE_URL, ApiList[1]);

        // MatchGoal
        public static string MatchGoal_API = String.Format(BASE_URL, ApiList[2]);

        // OverUnder
        public static string OverUnder_API = String.Format(BASE_URL, ApiList[3]);

        // Other apis Please contact https://github.com/BET365-API/BET365-API#contact;
        // -------------------api interface end -------------------

    }
}
