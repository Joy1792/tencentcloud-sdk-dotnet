/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DescribeVulInfoCvssResponse : AbstractModel
    {
        
        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 危害等级：1-低危；2-中危；3-高危；4-严重
        /// </summary>
        [JsonProperty("VulLevel")]
        public ulong? VulLevel{ get; set; }

        /// <summary>
        /// 漏洞分类 1: web-cms漏洞 2:应用漏洞  4: Linux软件漏洞 5: Windows系统漏洞
        /// </summary>
        [JsonProperty("VulType")]
        public ulong? VulType{ get; set; }

        /// <summary>
        /// 漏洞描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 修复方案
        /// </summary>
        [JsonProperty("RepairPlan")]
        public string RepairPlan{ get; set; }

        /// <summary>
        /// 漏洞CVEID
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// 参考链接
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// CVSS信息
        /// </summary>
        [JsonProperty("CVSS")]
        public string CVSS{ get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonProperty("PublicDate")]
        public string PublicDate{ get; set; }

        /// <summary>
        /// Cvss分数
        /// </summary>
        [JsonProperty("CvssScore")]
        public ulong? CvssScore{ get; set; }

        /// <summary>
        /// cvss详情
        /// </summary>
        [JsonProperty("CveInfo")]
        public string CveInfo{ get; set; }

        /// <summary>
        /// cvss 分数 浮点型
        /// </summary>
        [JsonProperty("CvssScoreFloat")]
        public float? CvssScoreFloat{ get; set; }

        /// <summary>
        /// 漏洞标签 多个逗号分割
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }

        /// <summary>
        /// 已防御的攻击次数
        /// </summary>
        [JsonProperty("DefenseAttackCount")]
        public ulong? DefenseAttackCount{ get; set; }

        /// <summary>
        /// 全网修复成功次数, 不支持自动修复的漏洞默认返回0
        /// </summary>
        [JsonProperty("SuccessFixCount")]
        public ulong? SuccessFixCount{ get; set; }

        /// <summary>
        /// 修复是否支持：0-windows/linux均不支持修复 ;1-windows/linux 均支持修复 ;2-仅linux支持修复;3-仅windows支持修复
        /// </summary>
        [JsonProperty("FixSwitch")]
        public long? FixSwitch{ get; set; }

        /// <summary>
        /// 是否支持防御： 0-不支持 1-支持
        /// </summary>
        [JsonProperty("SupportDefence")]
        public long? SupportDefence{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulLevel", this.VulLevel);
            this.SetParamSimple(map, prefix + "VulType", this.VulType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RepairPlan", this.RepairPlan);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "PublicDate", this.PublicDate);
            this.SetParamSimple(map, prefix + "CvssScore", this.CvssScore);
            this.SetParamSimple(map, prefix + "CveInfo", this.CveInfo);
            this.SetParamSimple(map, prefix + "CvssScoreFloat", this.CvssScoreFloat);
            this.SetParamSimple(map, prefix + "Labels", this.Labels);
            this.SetParamSimple(map, prefix + "DefenseAttackCount", this.DefenseAttackCount);
            this.SetParamSimple(map, prefix + "SuccessFixCount", this.SuccessFixCount);
            this.SetParamSimple(map, prefix + "FixSwitch", this.FixSwitch);
            this.SetParamSimple(map, prefix + "SupportDefence", this.SupportDefence);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

