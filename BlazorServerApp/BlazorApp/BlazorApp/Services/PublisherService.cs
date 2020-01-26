using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public class PublisherService : IPublisherService
    {
        public List<Publisher> Publishers { get; set; }

        public PublisherService()
        {
            Publishers = new List<Publisher>();

            Publishers.Add(new Publisher("0736", "New Moon Books", "Boston", "MA", "USA"));
            Publishers.Add(new Publisher("0877", "Binnet & Hardley", "Washington", "DC", "USA"));
            Publishers.Add(new Publisher("1389", "Algodata Infosystems", "Berkeley", "CA", "USA"));
            Publishers.Add(new Publisher("1622", "Five Lakes Publishing", "Chicago", "IL", "USA"));
            Publishers.Add(new Publisher("1756", "Ramona Publishers", "Dallas", "TX", "USA"));
        }

        public List<Publisher> GetPublishers()
        {
            return Publishers;
        }

        public Publisher GetPublisherById(string pubId)
        {
            return Publishers.Where(pub => pub.Pub_Id == pubId).FirstOrDefault();
        }

        public bool SavePublisher(Publisher publisher)
        {
            publisher.Pub_Id = GetNewId();
            Publishers.Add(publisher);
            return true;
        }

        private string GetNewId()
        {
            string id;
            Random random = new Random();
            id = random.Next(1000, 10000).ToString();

            return id;
        }

        public void DeletePublisher(string pubId)
        {
            throw new NotImplementedException();
        }
    }
}
