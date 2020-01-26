using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    interface IPublisherService
    {
        List<Publisher> GetPublishers();
        Publisher GetPublisherById(string pubId);
        bool SavePublisher(Publisher publisher);
        void DeletePublisher(string pubId);
    }
}
