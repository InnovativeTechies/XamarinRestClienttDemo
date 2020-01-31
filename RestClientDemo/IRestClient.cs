using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientDemo
{
    public interface IRestClient
    {
        Task<T> GetAsync<T>(string url, bool useAuthToken = false);
        Task<T> PostAsync<T>(string url, object payload, bool useAuthToken = false);
        Task<T> PutAsync<T>(string url, object payload, bool useAuthToken = false);
        Task<T> DeleteAsync<T>(string url, bool useAuthToken = false);
    }
}
