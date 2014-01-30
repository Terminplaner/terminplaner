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
        DBConnection dbCon = new DBConnection("localhost", "test", "root", "");
        const int uid = 0,
                  title = 1,
                  ort = 2,
                  start = 3,
                  ende = 4,
                  typ = 5,
                  person = 6,
                  beschreibung = 7,
                  typString = 8;

        public List<Termin> getAllTermine(int puid)
        {
            List<Termin> terminList = new List<Termin>();
            dbCon.Open();

            var reader = dbCon.Execute("SELECT termin.*, (SELECT title from termintyp where uid = termin.typ) as typ FROM termin WHERE termin.person = " + puid + " ORDER BY termin.start");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    switch ((int)reader.GetValue(typ))
                    {
                        case 1:
                            terminList.Add(
                                new Schulung(
                                    (int)reader.GetValue(uid),
                                    (string)reader.GetValue(title),
                                    (string)reader.GetValue(ort),
                                    (DateTime)reader.GetValue(start),
                                    (DateTime)reader.GetValue(ende),
                                    (string)reader.GetValue(typString)
                                )
                            );
                            break;
                        case 2:
                            terminList.Add(
                                new Meeting(
                                    (int)reader.GetValue(uid),
                                    (string)reader.GetValue(title),
                                    (string)reader.GetValue(ort),
                                    (DateTime)reader.GetValue(start),
                                    (DateTime)reader.GetValue(ende),
                                    (string)reader.GetValue(typString)
                                 )
                             );
                            break;
                        case 3:
                            terminList.Add(
                                new Urlaub(
                                    (int)reader.GetValue(uid),
                                    (string)reader.GetValue(title),
                                    (string)reader.GetValue(ort),
                                    (DateTime)reader.GetValue(start),
                                    (DateTime)reader.GetValue(ende),
                                    (string)reader.GetValue(typString)
                                )
                            );
                            break;
                        case 4:
                            terminList.Add(
                                new Aufgabe(
                                    (int)reader.GetValue(uid),
                                    (string)reader.GetValue(title),
                                    (string)reader.GetValue(ort),
                                    (DateTime)reader.GetValue(start),
                                    (DateTime)reader.GetValue(ende),
                                    (string)reader.GetValue(typString)
                                 )
                             );
                            break;
                    }
                }
            }
            else { return null; }

            dbCon.Close();
            return terminList;
        }

        public List<Termintyp> getAllTermintypes()
        {
            try
            {
                List<Termintyp> types = new List<Termintyp>();
                dbCon.Open();

                var reader = dbCon.Execute("SELECT Uid, Title FROM termintyp ORDER BY Title");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        types.Add(new Termintyp((int)reader.GetValue(uid), (string)reader.GetValue(title)));
                    }
                }
                else { return null; }
                return types;
            }
            finally
            {
                dbCon.Close();
            }
        }

        public void erstelleTermin(Termin termin, Person person)
        {
            dbCon.Open();

            if (termin.Title != "" && termin.Ort != "")
                dbCon.Execute(
                    "INSERT INTO  `test`.`termin` (`uid` ,`title` ,`ort` ,`start` ,`ende` ,`typ`,`person`)" +
                    "VALUES" +
                    "(NULL ,  '" + termin.Title + "',  '" + termin.Ort + "',  '" + termin.StartDatum.ToString("yyyy/MM/dd") + "',  '" + termin.EndDatum.ToString("yyyy/MM/dd") + "', '" + termin.Type + "', '" + person.Uid + "');");

            dbCon.Close();
        }

        public Person getPersonByName(string name)
        {
            dbCon.Open();
            Person tempPerson = null;
            MySqlDataReader reader = dbCon.Execute("SELECT * FROM person WHERE name='" + name + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tempPerson = new Person((int)reader.GetValue(uid), (string)reader.GetValue(1), (string)reader.GetValue(2));
                }
            }
            dbCon.Close();
            return tempPerson;
        }
    }
}
