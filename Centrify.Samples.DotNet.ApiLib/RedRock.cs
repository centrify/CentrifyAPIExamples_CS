﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;
//using System.Web.Script.Serialization; //Must include System.Web.Extensions as a referance.
//using APICodeSamples.Classes; //Centrify_API_Interface class location.

//namespace APICodeSamples
//{
//    class RedRock
//    {
//        public static string CentLoginURL = "https://cloud.centrify.com/security/login";
//        public static string CentQueryURL = "https://pod.centrify.com/RedRock/query";

//        public void RunQuery(string strUserName, string strPassword)
//        {
//            string loginJSON = "{user:'" + strUserName + "', password:'" + strPassword + "'}";
//            Centrify_API_Interface centLogin = new Centrify_API_Interface().MakeRestCall(CentLoginURL, loginJSON);

//            string strQueryJSON = @"{""Script"":""select * from dsusers where SystemName = '" + strUserName + @"';"",""Args"":{""PageNumber"":1,""PageSize"":10000,""Limit"":10000,""SortBy"":"""",""direction"":""False"",""Caching"":-1}}";

//            Centrify_API_Interface centQueryUser = new Centrify_API_Interface().MakeRestCall(CentQueryURL, strQueryJSON, centLogin.returnedCookie);
//            var jssFindUser = new JavaScriptSerializer();
//            Dictionary<string, dynamic> centQueryUser_Dict = jssFindUser.Deserialize<Dictionary<string, dynamic>>(centQueryUser.returnedResponse);

//            if (centQueryUser_Dict["success"].ToString() == "True")
//            {
//                Console.WriteLine("User Found:");

//                ArrayList centFindUser_Results = centQueryUser_Dict["Result"]["Results"];
//                dynamic centFindUser_Results_Column = centFindUser_Results[0];
//                Dictionary<string, dynamic> centFindUser_Results_Row = centFindUser_Results_Column["Row"];

//                bool bEnabled = centFindUser_Results_Row["Enabled"];
//                bool bLocked = centFindUser_Results_Row["Locked"];

//                Console.WriteLine("Account Enabled is: " + bEnabled.ToString() + ", Account Locked is: " + bLocked.ToString());
//            }
//            else
//            {
//                Console.WriteLine("Error Running Query: " + centQueryUser_Dict["Message"].ToString());
//            }
//        }

//    }
//}
