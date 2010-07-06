using System;
using System.Collections;
using System.Text;
using Azzeton.Shared;
using System.Collections.ObjectModel;
using System.Globalization;
using Azzeton.Core.Entity;
namespace Azzeton.Core
{
    public class CoreSecurity
    {
        private enum AccessCategory
        {
            SM,
            CM,
            AM
        }
        private static string RCText(AccessCategory category)
        {
            switch (category)
            {
                case AccessCategory.SM:
                    return "System Related";
                case AccessCategory.AM:
                    return "Application Related";
                case AccessCategory.CM:
                    return "Module Related";
                default:
                    return "Uncategorized";
            }
        }
        /// <summary>
        /// Collection of System Accesss
        /// </summary>
        public static Collection<Access> Access { get; private set; }
        private static Hashtable Current_Users_Accesss;

        //If you're not allowed to view Records, you're not allowed to search on that Records.
        //If you're not allowed to create Recordss and create Records, then you cannot import
        //If you're not allowed to create Recordss and create Records and create users, then you cannot migrate
        //IF you're not allowed to use Manager, you cannot import Records to Intray

        public static string ViewRecords { get { return  "__DM_01"; } }
        public static string Validate  { get { return"__DM_02"; } }
        public static string CreateRecords { get { return"__DM_03"; } }
        public static string ModifyRecords { get { return"__DM_04"; } }
        public static string DeleteRecords { get { return"__DM_05"; } }
        public static string ImportRecords { get { return"__DM_06"; } }
        public static string ExportToFileSystem { get { return"__DM_07"; } }
        public static string ExportToRecords { get { return"__DM_08"; } }
        public static string RecoverDocument { get { return"__DM_09"; } }
        public static string BackupRecords { get { return"__DM_10"; } }
        public static string PrintDocument { get { return"__DM_11"; } }
        public static string EmailDocument { get { return"__DM_12"; } }

        //public static bool ViewAllAnnotatins { get { return"__DM_12"; } }
        //public static bool CreateAnnotations { get { return"__DM_13"; } }
        //public static bool ModifyAllAnnotations { get { return"__DM_14"; } }
        //public static bool DeleteAllAnnotations { get { return"__DM_15"; } }

        public static bool UseManager { get { return A("__SM_01"); } }
        public static bool UseReminders { get { return A("__SM_02"); } }
        public static bool UseSets { get { return A("__SM_03"); } }
        public static bool ManageRecords { get { return A("__SM_05"); } }
        public static bool BackupSystem { get { return A("__SM_06"); } }
        public static bool ImportSystem { get { return A("__SM_07"); } }
        public static bool ManageUsersAndGroup { get { return A("__SM_08"); } }
        public static bool InstallModules { get { return A("__SM_09"); } }
        public static bool ViewStatistics { get { return A("__SM_10"); } }
        public static bool ViewAuditTrail { get { return A("__SM_11"); } }
        public static bool ViewLogs { get { return A("__SM_12"); } }
        public static bool RegisterProduct { get { return A("__SM_13"); } }
        public static bool UpdateProduct { get { return A("__SM_14"); } }
        public static bool ForwardRecords { get { return A("__SM_15"); } }
        public static bool SystemConfiguration { get { return A("__SM_16"); } }
       
        public static bool SetupSystemAccesss()
        {
            try
            {
                if (Access == null)
                {
                    Access = new Collection<Azzeton.Core.Entity.Access>();

                    Access.Add((Access)new Access("View Records", "See Records List & Tabs",  RCText(AccessCategory.AM), "__DM_01"));
                    Access.Add((Access)new Access("View Records", "View Records", RCText(AccessCategory.AM), "__DM_02"));
                    Access.Add((Access)new Access("Create Records", "Create / Input / Save Records Into Records",  RCText(AccessCategory.AM), "__DM_03"));
                    Access.Add((Access)new Access("Modify Records", "Modify / Edit Records",  RCText(AccessCategory.AM), "__DM_04"));
                    Access.Add((Access)new Access("Delete Records", "Remove Records From Records",  RCText(AccessCategory.AM), "__DM_05"));
                    Access.Add((Access)new Access("Import Records", "Import Records From Existing Backup",  RCText(AccessCategory.AM), "__DM_06"));
                    Access.Add((Access)new Access("Export To FileSystem", "Save Records To File System",  RCText(AccessCategory.AM), "__DM_07"));
                    Access.Add((Access)new Access("Export To Records", "Export Records To Another Records",  RCText(AccessCategory.AM), "__DM_08"));
                    Access.Add((Access)new Access("Recover Records", "Recover Delete Records", RCText(AccessCategory.AM), "__DM_09"));
                    Access.Add((Access)new Access("Backup Records", "Backup Records", RCText(AccessCategory.AM), "__DM_10"));
                    Access.Add((Access)new Access("Print Records", "Print Records", RCText(AccessCategory.AM), "__DM_11"));
                    Access.Add((Access)new Access("Email Records", "Email Records", RCText(AccessCategory.AM), "__DM_12"));
                    
                    //Accesss.Add((Access)new Access("View All Annotatins", "View All Document Annotations", AccessCategory.Document_Management_Records_Dependent.ToString(), "__DA_12"));
                    //Accesss.Add((Access)new Access("Create Annotations", "Create Document Annotations",  AccessCategory.Document_Management_Records_Dependent.ToString(), "__DA_13"));
                    //Accesss.Add((Access)new Access("Modify All Annotations", "Modify Document Annotations",  AccessCategory.Document_Management_Records_Dependent.ToString(), "__DA_14"));
                    //Accesss.Add((Access)new Access("Delete All Annotations", "Remove Document Annotations",  AccessCategory.Document_Management_Records_Dependent.ToString(), "__DA_15"));

                    Access.Add((Access)new Access("Use Manager", "Manage Manager",  RCText(AccessCategory.SM), "__SM_01"));
                    Access.Add((Access)new Access("Use Reminders", "Manage Document Reminders",  RCText(AccessCategory.SM), "__SM_02"));
                    Access.Add((Access)new Access("Use Sets", "Manage Document Sets",  RCText(AccessCategory.SM), "__SM_03"));
                    Access.Add((Access)new Access("Manage Recordss", "Create,Modify, and Delete Recordss",  RCText(AccessCategory.SM), "__SM_05"));
                    Access.Add((Access)new Access("Backup Records/System", "Backup Recordss or System", RCText(AccessCategory.SM), "__SM_06"));
                    Access.Add((Access)new Access("Import System", "Import System", RCText(AccessCategory.SM), "__SM_07"));
                    Access.Add((Access)new Access("Manage Users & Groups", "View, Create, Modify, and Delete Uses & Groups", RCText(AccessCategory.SM), "__SM_08"));
                    Access.Add((Access)new Access("Install Modules", "Install Custom Modules", RCText(AccessCategory.SM), "__SM_09"));
                    Access.Add((Access)new Access("View Statistics", "View System Statistics", RCText(AccessCategory.SM), "__SM_10"));
                    Access.Add((Access)new Access("View Audit Trail", "View Audit Trail", RCText(AccessCategory.SM), "__SM_11"));
                    Access.Add((Access)new Access("View Logs", "View System and Application Logs", RCText(AccessCategory.SM), "__SM_12"));
                    Access.Add((Access)new Access("Register Product", "Register / License /Activate Product", RCText(AccessCategory.SM), "__SM_13"));
                    Access.Add((Access)new Access("Update Product", "Update Product", RCText(AccessCategory.SM), "__SM_14"));
                    Access.Add((Access)new Access("Forward Records", "Forward Records To Other Users", RCText(AccessCategory.SM), "__SM_15"));
                    Access.Add((Access)new Access("System Configuration", "System Configuration", RCText(AccessCategory.SM), "__SM_16"));

                }
                return true;
            }
            catch (Exception ex) { FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now); }
            return false;
        }

        /// <summary>
        /// Get user's Accesss per Records
        /// </summary>
        /// <param name="userid">id of user</param>
        /// <param name="Recordsid">id of Records</param>
        public static void GetUserAccesss(int userid)
        {
            ////if (ProductSettings.ProductType != ProductType.Pocket && ProductSettings.ProductType != ProductType.Personal_Plus)
            ////{
            //    Current_Users_Accesss = null;
            //    Current_Users_Accesss = new Hashtable();

            //    Collection<IUserRight> _Accesss = new UserAccessManager().Get(CoreGlobals.Current_User.ID);
            //    string _code_name = "";
            //    foreach (IUserRight userAccess in _Accesss)
            //    {
            //        //if (userAccess.RightCode == "__SM_04")
            //        //    Current_Users_Recordss.Add(userAccess.RecordsID, true);
            //        if(userAccess.RightCode.StartsWith("__DM"))
            //            _code_name = userAccess.RightCode + "_" + userAccess.RecordsID;
            //        else
            //            _code_name = userAccess.RightCode;
            //        if(!Current_Users_Accesss.Contains(_code_name))
            //            Current_Users_Accesss.Add(_code_name, true);
            //    }

            //    /*very expensive joke*/
            //    Collection<IGroup> _groups = new UserGroupManager().GetGroups(CoreGlobals.Current_User.ID);
            //    foreach (IGroup group in _groups)
            //    {
            //        Collection<IGroupAccess> _groupAccesss = new GroupAccessManager().Get(group.ID);
            //        foreach (IGroupAccess groupAccess in _groupAccesss)
            //        {
            //            //if (groupAccess.RightCode == "__SM_04")
            //            //    if(!Current_Users_Recordss.Contains(groupAccess.RecordsID))
            //            //        Current_Users_Recordss.Add(groupAccess.RecordsID, true);

            //            if (groupAccess.RightCode.StartsWith("__DM"))
            //                _code_name = groupAccess.RightCode + "_" + groupAccess.RecordsID;
            //            else
            //                _code_name = groupAccess.RightCode;

            //            if (!Current_Users_Accesss.Contains(_code_name))
            //                Current_Users_Accesss.Add(_code_name, true);
            //        }
            //    }
            //}

        }
        /// <summary>
        /// Get user's Accesss per Records
        /// </summary>
        /// <param name="userid">id of user</param>
        /// <param name="Recordsid">id of Records</param>
        public static void GetUserAccesss(int userid, int Recordsid)
        {
            //Collection<IUserRight> _Accesss = new UserRightManager().t(userid, Recordsid);
            //if (Current_Users_Accesss == null)
            //    Current_Users_Accesss = new Hashtable();
            //Current_Users_Accesss.Clear();
            //foreach (IUserRight _Access in _Accesss)
            //{
            //    Current_Users_Accesss.Add(_Access.RightCode, true);
            //}
        }
        /// <summary>
        /// Fetches access from access list
        /// </summary>
        /// <param name="code">code</param>
        /// <returns>true if available, false otherwise</returns>
        public static bool A(string code)
        {
            return Convert.ToBoolean(Current_Users_Accesss[code], CultureInfo.InvariantCulture);
        }
        public static bool A(string code, int Recordsid)
        {
            return Convert.ToBoolean(Current_Users_Accesss[code+"_" + Recordsid.ToString()], CultureInfo.InvariantCulture);
        }
    }
}
