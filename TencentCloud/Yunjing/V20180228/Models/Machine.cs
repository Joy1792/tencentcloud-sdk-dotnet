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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Machine : AbstractModel
    {
        
        /// <summary>
        /// 主机名称。
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 主机系统。
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// 主机状态。
        /// <li>OFFLINE: 离线  </li>
        /// <li>ONLINE: 在线</li>
        /// <li>MACHINE_STOPPED: 已关机</li>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// 云镜客户端唯一Uuid，若客户端长时间不在线将返回空字符。
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// CVM或BM机器唯一Uuid。
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 漏洞数。
        /// </summary>
        [JsonProperty("VulNum")]
        public long? VulNum{ get; set; }

        /// <summary>
        /// 主机IP。
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 是否是专业版。
        /// <li>true： 是</li>
        /// <li>false：否</li>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// 主机外网IP。
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// 主机状态。
        /// <li>POSTPAY: 表示后付费，即按量计费  </li>
        /// <li>PREPAY: 表示预付费，即包年包月</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 木马数。
        /// </summary>
        [JsonProperty("MalwareNum")]
        public long? MalwareNum{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }

        /// <summary>
        /// 基线风险数。
        /// </summary>
        [JsonProperty("BaselineNum")]
        public long? BaselineNum{ get; set; }

        /// <summary>
        /// 网络风险数。
        /// </summary>
        [JsonProperty("CyberAttackNum")]
        public long? CyberAttackNum{ get; set; }

        /// <summary>
        /// 风险状态。
        /// <li>SAFE：安全</li>
        /// <li>RISK：风险</li>
        /// <li>UNKNOWN：未知</li>
        /// </summary>
        [JsonProperty("SecurityStatus")]
        public string SecurityStatus{ get; set; }

        /// <summary>
        /// 入侵事件数
        /// </summary>
        [JsonProperty("InvasionNum")]
        public long? InvasionNum{ get; set; }

        /// <summary>
        /// 地域信息
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "MalwareNum", this.MalwareNum);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "BaselineNum", this.BaselineNum);
            this.SetParamSimple(map, prefix + "CyberAttackNum", this.CyberAttackNum);
            this.SetParamSimple(map, prefix + "SecurityStatus", this.SecurityStatus);
            this.SetParamSimple(map, prefix + "InvasionNum", this.InvasionNum);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
        }
    }
}

