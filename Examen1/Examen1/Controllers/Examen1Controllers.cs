using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;
using Contactos.Models;
using System.Threading.Tasks;

namespace Examen1.Controllers
{
    public class Examen1Controllers : ContentPage

    {
        readonly SQLiteAsyncConnection connection;
        public Examen1Controllers();
        public Examen1Controller(String dbpath)
        

        {
            connection = new SQLiteAsyncConnection(dbpath);

            connection.CreateTableAsync<Examen1>().Wait();
        }

        public Task<int> SaveAlum(Alumno alumno)
        {

            if (Examen1.id != 0)
                return connection.UpdateAsync(Examen1);
            else
                return connection.InsertAsync(Examen1);
        }
        public Task<List<Alumno>> GetListAlumn()
        {
            return connection.Table<Examen1>().ToListAsync();
        }
        public Task<int> DeleteAlumn(Alumno alumno);
        
        
         }
}








