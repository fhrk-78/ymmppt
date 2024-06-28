using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace ymm_project_packingtool
{
    internal class ToDirectory
    {
        private string ymmppath;
        private string ouputpath;

        public ToDirectory(string symmppath, string soutputpath)
        {
            ymmppath = symmppath;
            ouputpath = soutputpath;
        }

        public async Task<string> Run()
        {
            YMMProjectFile? ymmpjson;
            string ymmpjsonresult;
            var sourcePaths = new List<string>();
            var outputGUIDs = new List<Guid>();

            try
            {
                // Init

                using (StreamReader ymmpsr = new(ymmppath))
                {
                    var res = await ymmpsr.ReadToEndAsync();
                    if (res == null) throw new IOException("Project file doesn't exist!");
                    ymmpjson = JsonSerializer.Deserialize<YMMProjectFile>(res);
                    if (ymmpjson == null) throw new IOException("Can't convert to YMMPJsonStyle!");
                }

                // Main

                foreach (var elm in ymmpjson.Timeline.Items)
                {
                    if (elm.FilePath != null)
                    {
                        sourcePaths.Add(elm.FilePath);
                        var guid = Guid.NewGuid();
                        outputGUIDs.Add(guid);
                        elm.FilePath = Path.GetFileName(Path.Combine(Path.GetDirectoryName(elm.FilePath), guid + "_" + Path.GetFileName(elm.FilePath)));
                    }
                }
                for (var i = 0; i < sourcePaths.LongCount(); i++)
                {
                    File.Copy(sourcePaths[i], Path.Combine(ouputpath, outputGUIDs[i].ToString() + "_" + Path.GetFileName(sourcePaths[i])), true);
                }

                // End

                ymmpjsonresult = JsonSerializer.Serialize(ymmpjson, new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
                });

                using (StreamWriter projfile = new(Path.Combine(ouputpath, "_プロジェクト.ymmp")))
                {
                    await projfile.WriteAsync(ymmpjsonresult);
                }
            }
            catch (IOException e)
            {
                return e.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "Compileted!";
        }
    }
}
