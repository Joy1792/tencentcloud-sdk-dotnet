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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VULRiskAdvanceCFGList : AbstractModel
    {
        
        /// <summary>
        /// 风险ID
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VULName")]
        public string VULName{ get; set; }

        /// <summary>
        /// 风险等级，low-低危，high-高危，middle-中危，info-提示，extreme-严重。
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 识别来源
        /// </summary>
        [JsonProperty("CheckFrom")]
        public string CheckFrom{ get; set; }

        /// <summary>
        /// 是否启用，1-启用，0-禁用
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("VULType")]
        public string VULType{ get; set; }

        /// <summary>
        /// 影响版本
        /// </summary>
        [JsonProperty("ImpactVersion")]
        public string ImpactVersion{ get; set; }

        /// <summary>
        /// CVE
        /// </summary>
        [JsonProperty("CVE")]
        public string CVE{ get; set; }

        /// <summary>
        /// 漏洞标签
        /// </summary>
        [JsonProperty("VULTag")]
        public string[] VULTag{ get; set; }

        /// <summary>
        /// 修复方式
        /// </summary>
        [JsonProperty("FixMethod")]
        public string[] FixMethod{ get; set; }

        /// <summary>
        /// 披露时间
        /// </summary>
        [JsonProperty("ReleaseTime")]
        public string ReleaseTime{ get; set; }

        /// <summary>
        /// 应急漏洞类型，1-应急漏洞，0-非应急漏洞
        /// </summary>
        [JsonProperty("EMGCVulType")]
        public long? EMGCVulType{ get; set; }

        /// <summary>
        /// 漏洞描述
        /// </summary>
        [JsonProperty("VULDescribe")]
        public string VULDescribe{ get; set; }

        /// <summary>
        /// 影响组件
        /// </summary>
        [JsonProperty("ImpactComponent")]
        public string ImpactComponent{ get; set; }

        /// <summary>
        /// 漏洞Payload
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// 技术参考
        /// </summary>
        [JsonProperty("References")]
        public string References{ get; set; }

        /// <summary>
        /// cvss评分
        /// </summary>
        [JsonProperty("CVSS")]
        public string CVSS{ get; set; }

        /// <summary>
        /// 攻击热度
        /// </summary>
        [JsonProperty("AttackHeat")]
        public string AttackHeat{ get; set; }

        /// <summary>
        /// 安全产品支持情况
        /// </summary>
        [JsonProperty("ServiceSupport")]
        public ServiceSupport[] ServiceSupport{ get; set; }

        /// <summary>
        /// 最新检测时间
        /// </summary>
        [JsonProperty("RecentScanTime")]
        public string RecentScanTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "VULName", this.VULName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "CheckFrom", this.CheckFrom);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VULType", this.VULType);
            this.SetParamSimple(map, prefix + "ImpactVersion", this.ImpactVersion);
            this.SetParamSimple(map, prefix + "CVE", this.CVE);
            this.SetParamArraySimple(map, prefix + "VULTag.", this.VULTag);
            this.SetParamArraySimple(map, prefix + "FixMethod.", this.FixMethod);
            this.SetParamSimple(map, prefix + "ReleaseTime", this.ReleaseTime);
            this.SetParamSimple(map, prefix + "EMGCVulType", this.EMGCVulType);
            this.SetParamSimple(map, prefix + "VULDescribe", this.VULDescribe);
            this.SetParamSimple(map, prefix + "ImpactComponent", this.ImpactComponent);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "References", this.References);
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "AttackHeat", this.AttackHeat);
            this.SetParamArrayObj(map, prefix + "ServiceSupport.", this.ServiceSupport);
            this.SetParamSimple(map, prefix + "RecentScanTime", this.RecentScanTime);
        }
    }
}

