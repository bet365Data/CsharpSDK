using System.Collections.Generic;

namespace bet365DataSDK.http
{
    public class Response
    {
        public string msg { get; set; }
        public Data data { get; set; }
        public int code { get; set; }

        public class DataList
        {
            public List<string> team_pair { get; set; }
            public List<string> team_score { get; set; }
            public List<string> play_time { get; set; }
            public List<object> handicap_list { get; set; }
            public List<string> odds_list { get; set; }
        }

        public class Details
        {
            public List<string> channel { get; set; }
            public List<DataList> data { get; set; }
        }

        public class Data
        {
            public Details data { get; set; }
            public int sync_time { get; set; }
        }

    }
}

