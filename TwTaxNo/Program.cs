using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaxNo
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //臺北市政府各機關學校統一編號 https://data.gov.tw/dataset/121974
            string url = "https://www.fia.gov.tw/download/9bc4de1485014443b518beb37d8f35fe";

            //中央政府機關資料集 https://data.gov.tw/dataset/44806
            string url1 = "https://www.fia.gov.tw/download/9bc4de1485014443b518beb37d8f35fe";

            //教育部屬館校統一编號彙總表 https://data.gov.tw/dataset/41400
            string url2 = "https://ws.moe.edu.tw/Download.ashx?u=C099358C81D4876C0C1AA24D0BCFA1D83FE3DC31E5E70B9E61144C6CA823494628B3FAE79969D8AC544A8C1B5ABAAF99B11F87F1EA4886A91B7D62A9594D333184FC97FA13A3D0834F8732C432305015&n=9C7FB99A9292FCA219EB2687135B9DD860864198994CE0BE5BE146D82659766447FB6115F3AE1026E24274BE88420B65&icon=..csv";

            //全國各級學校統一編號資料集 https://data.gov.tw/dataset/75136
            string url3 = "https://eip.fia.gov.tw/data/BGMOPEN99X.csv";


            await GetCsvStringAsync(url3);
        }

        private static async Task GetCsvStringAsync(string url)
        {
            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = Int32.MaxValue;
            var response = await client.GetStringAsync(url);

            Console.WriteLine(response);
        }
    }
}
