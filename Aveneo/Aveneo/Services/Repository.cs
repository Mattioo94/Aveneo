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
        private readonly ITools _tools;

        public Repository(DatabaseContext context, ITools tools)
        {
            _context = context;
            _tools = tools;
        }

        public Company FindCompany(string number)
        {
            number = _tools.ShortNumber(number);

            Company company = _context.Companies.ToList().FirstOrDefault(x => _tools.ShortNumber(x.Number) == number);
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
