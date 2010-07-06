using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.Windows.Forms;
using Azzeton.Shared;
using System.Drawing;

namespace Azzeton.Components
{
    public class HelpGenerator
    {
        public static string GenerateHTML(Message message)
        {
            string _folder = Path.Combine(Application.StartupPath, "Help");
            if (!Directory.Exists(_folder))
                Directory.CreateDirectory(_folder);
            StringBuilder _builder = new StringBuilder();
            string _file = Path.Combine(_folder, message.Code + ".htm");

            if (message.SnapShots.Count > 0)
            {
                Image _image;
                string _name;
                string _image_folder = Path.Combine(_folder, message.Code);
                if (!Directory.Exists(_image_folder))
                    Directory.CreateDirectory(_image_folder);
                _builder.Append("<ul>\n");
                for (int j = 0; j < message.SnapShots.Count; j++)
                {
                    _name = Path.Combine(_image_folder, message.Code + j.ToString() + ".png");
                    SnapShot _snapshot = message.SnapShots[j] as SnapShot;

                    _builder.AppendFormat(CultureInfo.InvariantCulture, "<li><p>{0}</p>", _snapshot.Description);
                    if (_snapshot.ImageData != null)
                    {
                        _image = Serializer.Deserialize<Image>(_snapshot.ImageData);
                        _image.Save(_name);
                        _builder.AppendFormat(CultureInfo.InvariantCulture, "<img src =\"{0}\"/><br/><b>SnapShot for step {1}</b><br/><br/>", _name, j + 1);
                    }
                    _builder.Append("</li>");
                }
                _builder.Append("</ul>\n");
            }

           string _html = string.Format(CultureInfo.InvariantCulture,
                        "<html><head><title>{0}</title></head>" +
                        "<body>" +
                        "<h2>{0}</h2>({1})" +
                        "<h3>Did you know...</h3>" +
                        "<p>{2}</p>" +
                        "<h4>How?</h4>" +
                        "<div>{3}</div>" +
                        "</body></html>", message.Title, message.Code, message.Info, _builder.ToString());

           using (StreamWriter writer = new StreamWriter(_file, false))
           {
               writer.WriteLine(_html);
               writer.Close();
           }

           return _file;
        }
        public static bool HelpFileExist(Message message, out string filename)
        {
            string _folder = Path.Combine(Application.StartupPath, "Help");
            string _file = Path.Combine(_folder, message.Code + ".htm");
            filename = _file;
            return File.Exists(_file);
        }
    }
}
