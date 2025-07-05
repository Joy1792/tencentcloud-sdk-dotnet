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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EffectiveMachineInfo : AbstractModel
    {
        
        /// <summary>
        /// 机器名称
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 机器公网ip
        /// </summary>
        [JsonProperty("MachinePublicIp")]
        public string MachinePublicIp{ get; set; }

        /// <summary>
        /// 机器内网ip
        /// </summary>
        [JsonProperty("MachinePrivateIp")]
        public string MachinePrivateIp{ get; set; }

        /// <summary>
        /// 机器标签
        /// </summary>
        [JsonProperty("MachineTag")]
        public MachineTag[] MachineTag{ get; set; }

        /// <summary>
        /// 机器Quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机Uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 内核版本号
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// 在线状态 OFFLINE，ONLINE
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// 授权订单对象
        /// </summary>
        [JsonProperty("LicenseOrder")]
        public LicenseOrder LicenseOrder{ get; set; }

        /// <summary>
        /// 漏洞数量
        /// </summary>
        [JsonProperty("VulNum")]
        public ulong? VulNum{ get; set; }

        /// <summary>
        /// 云标签信息
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// 机器instance ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachinePublicIp", this.MachinePublicIp);
            this.SetParamSimple(map, prefix + "MachinePrivateIp", this.MachinePrivateIp);
            this.SetParamArrayObj(map, prefix + "MachineTag.", this.MachineTag);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamObj(map, prefix + "LicenseOrder.", this.LicenseOrder);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
        }
    }
}

