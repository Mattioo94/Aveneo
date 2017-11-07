using Aveneo.Persistance;
using Aveneo.Services.IoC;
using Aveneo.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace Aveneo.Services
{
    class Repository : IRepository
    {
        private readonly DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }

        public Company FindCompany(string number)
        {
            Company company = _context.Companies.ToList().FirstOrDefault(x => x.Number == number);
            return company;
        }

        public void SaveRequest(IHeaderDictionary headerDictionary, string number)
        {
            string headers = JsonConvert.SerializeObject(headerDictionary);

            var request = new Request
            {
                Date = DateTime.Now,
                Number = number,
                Headers = headers
            };

            _context.Requests.Add(request);
            _context.SaveChanges();
        }
    }
}
