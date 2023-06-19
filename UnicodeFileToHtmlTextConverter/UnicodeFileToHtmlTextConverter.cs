using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public class UnicodeFileToHtmlTextConverter
    {
        public UnicodeFileToHtmlTextConverter()
        {

        }

        public string ConvertToHtml(string fullFilenameWithPath)
        {
            using (TextReader unicodeFileStream = File.OpenText(fullFilenameWithPath))
            {
                string html = string.Empty;

                string line = unicodeFileStream.ReadLine();
                while (line != null)
                {
                    html += HttpUtility.HtmlEncode(line);
                    html += "<br />";
                    line = unicodeFileStream.ReadLine();
                }

                return html;
            }
        }
    }
}
