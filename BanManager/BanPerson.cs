using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanManager
{
    class BanPerson
    {
        private long qqid;
        private string reason, evidence;
        /// <summary>
        /// 初始化一个被ban的人
        /// </summary>
        /// <param name="qqid">QQ号（防止改名字）</param>
        /// <param name="reason">封禁原因</param>
        /// <param name="evidence">证据（文件路径）</param>
        public BanPerson(long qqid, string reason, string evidence)
        {
            this.qqid = qqid;
            this.reason = reason;
            this.evidence = evidence;
        }
        public long getQQ()
        {
            return qqid;
        }
        public string getReason()
        {
            return reason;
        }
        public string getEvidence()
        {
            return evidence;
        }
    }
}
