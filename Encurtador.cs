using System;
using System.IO;
using System.Net;

namespace API_EncurtadorURL
{
    public static class Encurtador
    {
        

        public static string Encurtador_URL(string strURL)
        {
                 

                
                string URL = "http://tinyurl.com/api-create.php?url=" + strURL.ToLower();

                System.Net.HttpWebRequest objWebRequest;
                System.Net.HttpWebResponse objWebResponse;

                System.IO.StreamReader srReader;

                string strHTML;

                objWebRequest = (System.Net.HttpWebRequest)System.Net
                   .WebRequest.Create(URL);
                objWebRequest.Method = "GET";

                objWebResponse = (System.Net.HttpWebResponse)objWebRequest
                   .GetResponse();
                srReader = new System.IO.StreamReader(objWebResponse
                   .GetResponseStream());

                strHTML = srReader.ReadToEnd();

                srReader.Close();
                objWebResponse.Close();
                objWebRequest.Abort();

                return strHTML;

            
        }


        
       

    }
}
