using System;
using System.Collections.Generic;
using plan_your_vote_server_side_blazor.Data;


namespace AppDataService.Services
{
    public class AppData
    {
        public string q1 = "Unanswered";

        public string q2 = "Unanswered";

        public Person mayor = new Person();

        public List<Person> councillor = new List<Person>();

        public List<Person> park = new List<Person>();
        
        public List<Person> school = new List<Person>();
    }
}