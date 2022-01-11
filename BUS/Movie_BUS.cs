using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BUS
{
    public class Movie_BUS
    {
        Moive_DTO mv = new Moive_DTO();
        public Movie_BUS() 
        { 
             mv = new Moive_DTO(); 
        }
        public Movie_BUS(int id, string name,string type,string time,string hours) 
        { 
             mv = new Moive_DTO(id,name,type,time,hours); 
        }
        public bool insertMovie()
        {
           return mv.InsertMovie();
        }
        public bool deleteMovie(string s)
        {
            return mv.DeleteMovie(s);
        }
        public bool editMovie(int id, string name, string type, string timeshow, string hours)
        {
            return mv.EditMoive(id,name,type,timeshow,hours);
        }
        public DataTable displayMovie(string sql)
        {
            return mv.DisplayMovie(sql);
        }
    }
}
