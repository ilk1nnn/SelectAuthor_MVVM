using SelectAuthor_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectAuthor_MVVM.Repositories
{
    public class AuthorRepository
    {

        public static List<Author> AuthorRepo { get; set; }

        public static void GetAllAuthors()
        {
            var authors = new List<Author>();
            using(var conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=STHQ0127-03;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn.Open();
               
                SqlCommand cmd = new SqlCommand("SELECT * FROM Authors",conn);

                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string firstName = string.Empty;
                        string lastName = string.Empty;
                        int id = 0;

                        id = reader.GetFieldValue<int>(0);
                        firstName = reader.GetFieldValue<string>(1);
                        lastName = reader.GetFieldValue<string>(2);

                        Author author = new Author
                        {
                            Id = id,
                            FirstName = " "+firstName,
                            LastName = " "+lastName
                        };

                        authors.Add(author);

                    }
                }




            }

            AuthorRepo = authors;

        }


    }
}
