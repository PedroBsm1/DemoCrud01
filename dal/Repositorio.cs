using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace dal
{
    public class Repositorio

    {
        private IMongoCollection<Agenda> _agenda;
        public List<Agenda> ListaAgenda
        {
            get
            {
                var filter= Builders<Agenda>.Filter.Empty;
                return _agenda.Find<Agenda>(filter).ToList<Agenda>();
            }
        }
        public Repositorio()
        {
            var mongoClient = new MongoClient("mongodb+srv://pm214701:pm214701@cluster0.dbbjnga.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("appdesktopAgenda");
            _agenda = mongoDatabase.GetCollection<Agenda>("agenda");

        }
    }
}
