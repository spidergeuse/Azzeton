using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Azzeton.Shared
{
    public class General
    {
        public static string GetStamp()
        {
            string _id = string.Format(CultureInfo.InvariantCulture, "{0:ddMMyyyyHHmmssffff}", DateTime.Now);
            if (ProductSettings.UseLocalIDGenerationForNetworkKindSetup)
                _id += Volume.GetVolumeSerial();
            return _id;
        }
        public static string ValidateName(string name)
        {
            return name.Replace(" ", "_").Replace(".", "_");
        }
        public static bool ValidateEmail(string email)
        {
            if (Regex.Match(email, @"^[a-zA-Z][a-zA-Z0-9_-]+@[a-zA-Z]+[.]{1}[a-zA-Z]+$").Success)
                return true;
            return false;
        }
    }
}
