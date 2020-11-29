using System;
using plan_your_vote_server_side_blazor.Data;

namespace AppDataService.Services
{
    public class AppData
    {
        public string q1 { get; set; }

        public string q2 { get; set; }

        public Person mayor { get; set;}

        public Person[] councillor {get; set;}

        public Person[] park {get; set;}

        public Person[] school {get; set;}
    }
}