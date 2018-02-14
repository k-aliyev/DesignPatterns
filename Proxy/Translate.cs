using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace Proxy
{
    [Serializable]
    class TranslateProxy
    {
        
        BinaryFormatter formatter_byte = new BinaryFormatter();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        TranslateMain main;

        public string GetTranslate(string text)
        {
            if (!dictionary.ContainsKey(text))
            {
                if (main == null)
                    main = new TranslateMain();

                dictionary.Add(text, main.Translate(text));
            }
            return dictionary[text];
        }
        public void FillProxy()
        {
            dictionary.Add("привет", "hello");
            dictionary.Add("пока", "bye");
            dictionary.Add("дорога", "road");
            dictionary.Add("ад", "hell");
            dictionary.Add("программирование", "programming");
            dictionary.Add("рустам", "LOX");
            dictionary.Add("циклический", "cyclical");
            dictionary.Add("год", "year");
            dictionary.Add("месяц", "month");
            dictionary.Add("день", "day");
            dictionary.Add("час", "hour");
            dictionary.Add("минута", "minute");
            dictionary.Add("секунда", "second");
        }
        public void SafeDictionary()
        {
            using (FileStream f = new FileStream("Dictionary.bin", FileMode.OpenOrCreate))
            {
                formatter_byte.Serialize(f, dictionary);
            }
        }

    }

    class TranslateMain
    {
        public TranslateMain()
        {
            Thread.Sleep(3000);
        }

        public string Translate(string text)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            var url = $"https://translate.yandex.net//api/v1.5/tr.json/translate?key=trnsl.1.1.20171221T171400Z.c217d4144d9627ce.a8659a8b22b0690ff8bf78982ffc65d4ccaeb9f3&text={text}&lang=en";
            var date = webClient.DownloadString(url);
            dynamic jsonRespouse = JObject.Parse(date);
            return jsonRespouse.text[0];
        }
    }

    
}
