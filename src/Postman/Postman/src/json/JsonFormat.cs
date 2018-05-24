using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Postman.src.json
{
    class JsonFormat
    {
        public static String formatJson(String json)
        {
            try
            {
                //格式化json字符串
                JsonSerializer serializer = new JsonSerializer();

                TextReader tr = new StringReader(json);
                JsonTextReader jtr = new JsonTextReader(tr);
                object obj = serializer.Deserialize(jtr);
                if (obj != null)
                {
                    StringWriter textWriter = new StringWriter();
                    JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                    {
                        Formatting = Formatting.Indented,
                        Indentation = 4,
                        IndentChar = ' '
                    };
                    serializer.Serialize(jsonWriter, obj);
                    return textWriter.ToString();
                }
                else
                {
                    return json;
                }
            }
            catch
            {
                return json;
            }
        }
    }
}
