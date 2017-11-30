using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NetCore
{
    public class shomare
    {
        int count=0;
        public string dada()
        {
            while (true)
            {
                if (DateTime.Now.Minute.ToString().Contains("5"))
                {
                    try
                    {
                        System.Net.WebRequest request = WebRequest.Create("http://mohemnis.somee.com/");
                        request.GetResponseAsync();
                        count++;
                        return count.ToString();

                    }
                    catch
                    { return count.ToString() + "error"; }
                }
            }
        } 
    }
}
