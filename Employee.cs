using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1003
{
    public class Employee    //跟0926對比
    {
        public string Name { get; set; }   
        public bool Gender { get; set; }
        public List<string> Skills { get; set; }    
        public string get_info()
        {
            string r = "";
            if (Gender==true)
            {
                r = r + "Mr. ";
            }
            else
            {
                r = r + "Miss ";
            }
            r = r + Name + "<br>";
            foreach(string i in Skills)
            {
                r = r + i + "<br>";
            }
            return r;
        }
    }
}