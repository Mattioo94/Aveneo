using Aveneo.Models;
using Microsoft.AspNetCore.Http;

namespace Aveneo.Services.IoC
{
    public interface IRepository
    {
        void SaveRequest(IHeaderDictionary headerDictionary, string number);
        Company FindCompany(string number);
    }
}
