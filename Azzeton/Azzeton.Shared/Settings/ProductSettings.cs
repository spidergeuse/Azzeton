/*USE THIS TO DEFINE PRODUCT SETTINGS BEFORE COMPILING*/


/***********************************************/
/*             PRODUCT TYPE 
/***********************************************/
#define PERSONAL
//#define SMALL_BUSINESS
//#define BUSINESS
/**********************************************/


/***********************************************/
/*             PRODUCT LIMIT CHECKS 
/***********************************************/
#define RECORD_COUNTWISE
//#define DATE_RANGEWISE
//#define USERCOUNTWISE 
#define DEMOINSTALLATION
#define HIDE_INBUILT_USERS
#define USELICENSEPLUGIN
//#define USE_LOCAL_ID_GENERATIOIN_FOR_NETWORK_SETUP
//#define ENABLEDEBUGAUTOLOGIN
#define SHORTSTARTUPINFODELAY


/***********************************************/
/*             PRODUCT UI FEATURES 
/***********************************************/
//#define USERDI
#define USEBOTH
//#define USEWINCONTROLS

/*USE THIS TO DEFINE PRODUCT SETTINGS BEFORE COMPILING*/


using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

using Azzeton.Shared
namespace Azzeton.Shared
{
    public static class ProductSettings
    {
        public static void Initialize()
        {
            string _base_name = "Azzeton";
            string _base_host = "azzeton";
            ProductName = _base_name;
            ProductNameAndVersion = ProductName + " | 1";
            ProductCompany = _base_name;
            ProductVersion = "1.0";
            ProductAuthor = _base_name;
            ProductURL = string.Format(CultureInfo.InvariantCulture, "http://www.{0}.com/", _base_host.ToLowerInvariant());
            ProductPluginURL = string.Format(CultureInfo.InvariantCulture, "http://www.{0}.com/1/plugins/", _base_host.ToLowerInvariant());
            ProductUpdateURL = string.Format(CultureInfo.InvariantCulture, "http://www.{0}.com/update/", _base_host.ToLowerInvariant());
            if (_base_name.ToLowerInvariant() == "azzeton")
            {
                ProductSettingType = SettingType.Custom;
                ProductFileExtension = ".AZZ";
            }
            else
            {
                ProductSettingType = SettingType.Generic;
                ProductFileExtension = ".GEN";
            }

            ImageSuffix = "_" + ProductSettings.ProductSettingType.ToString().Substring(0, 1).ToLowerInvariant();
            DataSource = "";
            #if PERSONAL
                ProductType = ProductType.Personal;
            #elif SMALL_BUSINESS
                    ProductType = ProductType.Small_Business;
            #elif BUSINESS
                    ProductType = ProductType.Business;
            #endif

            #if RECORD_COUNTWISE
                LimitCheck = CheckType.RecordCount;
            #endif

            #if HIDE_INBUILT_USERS
                HideInbuiltUser = true;
            #endif


            #if DEMOINSTALLATION
                InstallationType = InstallationType.Demo;
            #else
                    InstallationType = InstallationType.Actual;
            #endif


            #if USE_LOCAL_ID_GENERATIOIN_FOR_NETWORK_SETUP
                    UseLocalIDGenerationForNetworkKindSetup = true;
            #endif


            #if USERDI
                    UseRDI = true;
            #endif

            #if USEBOTH
                UseBoth = true;
            #endif

            #if ENABLEDEBUGAUTOLOGIN
                    EnableDebugAutoLogin = true;
            #endif


            #if SHORTSTARTUPINFODELAY
                StartupInfoDelay = 2000;
            #else
                    StartupInfoDelay = 4000;
            #endif

            #if USEWINCONTROLS
                    UseWinControls = true;
            #endif

        }

        public static string ProductName { get; private set; }
        public static string ProductTitle
        { get { return ProductName + " " + ProductType.ToString().Replace("_", " "); } }
        public static string ProductFileExtension { get; private set; }
        public static string ProductNameAndVersion { get; private set; }
        public static string ProductCompany { get; private set; }
        public static string ProductVersion { get; private set; }
        public static string ProductURL { get; private set; }
        public static string ProductPluginURL { get; private set; }
        public static string ProductUpdateURL { get; private set; }
        public static string ProductAuthor { get; private set; }
        public static string ImageSuffix { get; private set; }
        public static int SystemIDLength { get { return UseLocalIDGenerationForNetworkKindSetup ? 50 : 20; } }
        public static SettingType ProductSettingType { get; private set; }
        public static ProductType ProductType
        {
            get;
            private set;
        }
        public static CheckType LimitCheck
        {
            get;
            private set;
        }
        public static string LimitCheckString
        {
            get
            {
                switch (LimitCheck)
                {
                    case CheckType.DateRange:
                        return "Limited Date";
                    case CheckType.RecordCount:
                        return "Limited Saves";
                    case CheckType.UserCount:
                        return "Limited User";
                    case CheckType.WorkstationCount:
                        return "Limited Workstation";
                    default:
                        return "Limited Saves Version";
                }
            }
        }
        public static bool HideInbuiltUser { get; private set; }
        public static bool EnableInsertFromScannerInViewer { get; private set; }
        public static bool UseLicensePlugin { get; private set; }
        public static bool UseLocalIDGenerationForNetworkKindSetup { get; private set; }
        public static bool ShowCabinetLockMenuOnCabinetForm { get; private set; }
        public static bool ShowExportToCabinetInDocumentViewer { get; private set; }
        public static bool UseBoth { get; private set; }
        public static bool UseWinControls { get; private set; }
        public static int StartupInfoDelay { get; private set; }
        public enum CheckType
        {
            RecordCount,
            UserCount,
            WorkstationCount,
            DateRange
        }
        public static bool UseRDI { get; private set; }
        public static bool EnableDebugAutoLogin { get; private set; }
        public static bool UseFixedValueCabinetFieldType { get; private set; }
        public static bool UseUpdatableValueCabinetFieldType { get; private set; }
        public static string DataSource { get; set; }
        public static bool CreateMyDocumentsCabinet { get; private set; }
    }
}
