using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Runtime.Remoting;

namespace Terminplaner
{
    
    class Repository
    {
        DBConnection dbCon = new DBConnection("localhost", "terminplaner", "root", "");

        public List<Termin> getAllTermine()
        {
            List<Termin> terminList = new List<Termin>();

            dbCon.Open();
            
            var reader =  dbCon.Execute("select * from termine");
            dbCon.Close();
            if(reader.HasRows){
            while (reader.Read())
            {
                string model = ((Termin.TypePool)reader.GetInt32(0)).ToString();
                var tmp = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(model); 

                switch (reader.GetInt32(0))
                {
                    case 1:
                        terminList.Add(new Meeting(156,"ztfhjkm",new DateTime(),new DateTime()));
                        break;
                        
                    case 2:
                        terminList.Add(new Schulung(156, "ztfhjkm", new DateTime(), new DateTime()));
                        break;

                    case 3:
                        terminList.Add(new Urlaub(156, "ztfhjkm", new DateTime(), new DateTime()));
                        break;
                }
                
            }
            }
            else{return null;}

            return terminList;
            
        }

    }
}
