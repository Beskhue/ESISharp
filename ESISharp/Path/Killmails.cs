﻿using ESISharp.Web;

namespace ESISharp.ESIPath
{
    /// <summary>Public Killmail paths</summary>
    public class Killmails
    {
        protected ESIEve EasyObject;

        internal Killmails(ESIEve EasyEve)
        {
            EasyObject = EasyEve;
        }

        /// <summary>Get A Single Killmail</summary>
        /// <param name="KillmailID">(Int32) Killmail ID</param>
        /// <param name="KillmailHash">(String) Base64 Killmail Hash</param>
        /// <returns>EsiRequest</returns>
        public EsiRequest GetSingle(int KillmailID, string KillmailHash)
        {
            var Path = $"/killmails/{KillmailID.ToString()}/{KillmailHash.ToString()}/";
            return new EsiRequest(EasyObject, Path, EsiWebMethod.Get);
        }
    }

    /// <summary>Public and Authenticated paths</summary>
    public class AuthKillmails : Killmails
    {
        internal AuthKillmails(ESIEve EasyEve) : base(EasyEve)
        {
            EasyObject = EasyEve;
        }
    }
}