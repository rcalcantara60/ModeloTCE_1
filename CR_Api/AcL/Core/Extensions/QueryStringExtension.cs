using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AcL.Core.Extensions
{
    public static class QueryStringExtension
    {
        public static Uri ToUri(this string query, object request)
        {
            var httpValueCollection = HttpUtility.ParseQueryString(string.Empty);

            var properties = request.GetType().GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(request);
                if (value != null)
                    httpValueCollection.AddParam(property.Name, value);
            }

            var ub = new UriBuilder(query);
            ub.Query = httpValueCollection.ToString();
            return ub.Uri;
        }

        private static void AddParam(this NameValueCollection httpValueCollection, string name, object obj)
        {
            if (obj is ICollection<long>)
                httpValueCollection.AddParam(name, (ICollection<long>)obj);
            else if (obj is DateTime)
                httpValueCollection.AddParam(name, (DateTime)obj);
            else
                httpValueCollection.Add(name, obj.ToString());
        }

        private static void AddParam(this NameValueCollection httpValueCollection, string name, ICollection<long> list)
        {
            foreach (var item in list)
                httpValueCollection.Add(name, item.ToString());
        }

        private static void AddParam(this NameValueCollection httpValueCollection, string name, DateTime dateTime)
        {
            httpValueCollection.Add(name, dateTime.ToString("yyyy-MM-dd"));
        }
    }
}
