/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditLog : AbstractModel
    {
        
        /// <summary>
        /// 影响行数。
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// SQL 类型。
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// 审计策略名称，逐步下线。
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("DBName")]
        public string DBName{ get; set; }

        /// <summary>
        /// SQL 语句。
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// 客户端地址。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 执行时间，微秒。
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// 时间。
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// 返回行数。
        /// </summary>
        [JsonProperty("SentRows")]
        public long? SentRows{ get; set; }

        /// <summary>
        /// 线程ID。
        /// </summary>
        [JsonProperty("ThreadId")]
        public long? ThreadId{ get; set; }

        /// <summary>
        /// 扫描行数。
        /// </summary>
        [JsonProperty("CheckRows")]
        public long? CheckRows{ get; set; }

        /// <summary>
        /// cpu执行时间，微秒。
        /// </summary>
        [JsonProperty("CpuTime")]
        public float? CpuTime{ get; set; }

        /// <summary>
        /// IO等待时间，微秒。
        /// </summary>
        [JsonProperty("IoWaitTime")]
        public ulong? IoWaitTime{ get; set; }

        /// <summary>
        /// 锁等待时间，微秒。
        /// </summary>
        [JsonProperty("LockWaitTime")]
        public ulong? LockWaitTime{ get; set; }

        /// <summary>
        /// 开始时间，与timestamp构成一个精确到纳秒的时间。
        /// </summary>
        [JsonProperty("NsTime")]
        public ulong? NsTime{ get; set; }

        /// <summary>
        /// 事物持续时间，微秒。
        /// </summary>
        [JsonProperty("TrxLivingTime")]
        public ulong? TrxLivingTime{ get; set; }

        /// <summary>
        /// 日志命中规则模板的基本信息
        /// </summary>
        [JsonProperty("TemplateInfo")]
        public LogRuleTemplateInfo[] TemplateInfo{ get; set; }

        /// <summary>
        ///  事务ID
        /// </summary>
        [JsonProperty("TrxId")]
        public long? TrxId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "DBName", this.DBName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "SentRows", this.SentRows);
            this.SetParamSimple(map, prefix + "ThreadId", this.ThreadId);
            this.SetParamSimple(map, prefix + "CheckRows", this.CheckRows);
            this.SetParamSimple(map, prefix + "CpuTime", this.CpuTime);
            this.SetParamSimple(map, prefix + "IoWaitTime", this.IoWaitTime);
            this.SetParamSimple(map, prefix + "LockWaitTime", this.LockWaitTime);
            this.SetParamSimple(map, prefix + "NsTime", this.NsTime);
            this.SetParamSimple(map, prefix + "TrxLivingTime", this.TrxLivingTime);
            this.SetParamArrayObj(map, prefix + "TemplateInfo.", this.TemplateInfo);
            this.SetParamSimple(map, prefix + "TrxId", this.TrxId);
        }
    }
}

