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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Command : AbstractModel
    {
        
        /// <summary>
        /// 命令
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }

        /// <summary>
        /// 命令输入的时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 命令执行时间相对于所属会话开始时间的偏移量，单位ms
        /// </summary>
        [JsonProperty("TimeOffset")]
        public ulong? TimeOffset{ get; set; }

        /// <summary>
        /// 命令执行情况，1--允许，2--拒绝，3--确认
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [JsonProperty("Sid")]
        public string Sid{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 设备account
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 设备ip
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// source ip
        /// </summary>
        [JsonProperty("FromIp")]
        public string FromIp{ get; set; }

        /// <summary>
        /// 该命令所属会话的会话开始时间
        /// </summary>
        [JsonProperty("SessTime")]
        public string SessTime{ get; set; }

        /// <summary>
        /// 该命令所属会话的会话开始时间
        /// </summary>
        [JsonProperty("SessionTime")]
        public string SessionTime{ get; set; }

        /// <summary>
        /// 复核时间
        /// </summary>
        [JsonProperty("ConfirmTime")]
        public string ConfirmTime{ get; set; }

        /// <summary>
        /// 用户部门id
        /// </summary>
        [JsonProperty("UserDepartmentId")]
        public string UserDepartmentId{ get; set; }

        /// <summary>
        /// 用户部门name
        /// </summary>
        [JsonProperty("UserDepartmentName")]
        public string UserDepartmentName{ get; set; }

        /// <summary>
        /// 设备部门id
        /// </summary>
        [JsonProperty("DeviceDepartmentId")]
        public string DeviceDepartmentId{ get; set; }

        /// <summary>
        /// 设备部门name
        /// </summary>
        [JsonProperty("DeviceDepartmentName")]
        public string DeviceDepartmentName{ get; set; }

        /// <summary>
        /// 会话大小
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 签名值
        /// </summary>
        [JsonProperty("SignValue")]
        public string SignValue{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("DeviceKind")]
        public string DeviceKind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "TimeOffset", this.TimeOffset);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Sid", this.Sid);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "FromIp", this.FromIp);
            this.SetParamSimple(map, prefix + "SessTime", this.SessTime);
            this.SetParamSimple(map, prefix + "SessionTime", this.SessionTime);
            this.SetParamSimple(map, prefix + "ConfirmTime", this.ConfirmTime);
            this.SetParamSimple(map, prefix + "UserDepartmentId", this.UserDepartmentId);
            this.SetParamSimple(map, prefix + "UserDepartmentName", this.UserDepartmentName);
            this.SetParamSimple(map, prefix + "DeviceDepartmentId", this.DeviceDepartmentId);
            this.SetParamSimple(map, prefix + "DeviceDepartmentName", this.DeviceDepartmentName);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "SignValue", this.SignValue);
            this.SetParamSimple(map, prefix + "DeviceKind", this.DeviceKind);
        }
    }
}

