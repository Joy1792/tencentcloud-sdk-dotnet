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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDSPAAssessmentLatestRiskDetailInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 数据源name
        /// </summary>
        [JsonProperty("DataSourceName")]
        public string DataSourceName{ get; set; }

        /// <summary>
        /// 资产对象名称
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 风险评估模板id
        /// </summary>
        [JsonProperty("AssessmentTemplateId")]
        public long? AssessmentTemplateId{ get; set; }

        /// <summary>
        /// 分类分级的模板id
        /// </summary>
        [JsonProperty("IdentifyTemplateId")]
        public long? IdentifyTemplateId{ get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// 风险项
        /// </summary>
        [JsonProperty("RiskName")]
        public string RiskName{ get; set; }

        /// <summary>
        /// 风险的描述
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }

        /// <summary>
        /// 风险的级别
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 处置的建议
        /// </summary>
        [JsonProperty("SuggestAction")]
        public string SuggestAction{ get; set; }

        /// <summary>
        /// 处置状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 安全产品
        /// </summary>
        [JsonProperty("SecurityProduct")]
        public SecurityProduct[] SecurityProduct{ get; set; }

        /// <summary>
        /// 风险归属
        /// </summary>
        [JsonProperty("RiskDimension")]
        public string RiskDimension{ get; set; }

        /// <summary>
        /// 关联数据库（如果风险归属是instance）
        /// </summary>
        [JsonProperty("RelationAsset")]
        public string[] RelationAsset{ get; set; }

        /// <summary>
        /// 风险账号详情
        /// </summary>
        [JsonProperty("AccountRiskDetail")]
        public AccountRisk[] AccountRiskDetail{ get; set; }

        /// <summary>
        /// 权限风险详情
        /// </summary>
        [JsonProperty("PrivilegeRiskDetail")]
        public PrivilegeRisk[] PrivilegeRiskDetail{ get; set; }

        /// <summary>
        /// 策略风险的cos风险文件列表
        /// </summary>
        [JsonProperty("PolicyRiskCosFileList")]
        public string[] PolicyRiskCosFileList{ get; set; }

        /// <summary>
        /// AKSK泄漏列表
        /// </summary>
        [JsonProperty("AKSKLeak")]
        public AKSKLeak[] AKSKLeak{ get; set; }

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
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "DataSourceName", this.DataSourceName);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssessmentTemplateId", this.AssessmentTemplateId);
            this.SetParamSimple(map, prefix + "IdentifyTemplateId", this.IdentifyTemplateId);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "RiskName", this.RiskName);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "SuggestAction", this.SuggestAction);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "SecurityProduct.", this.SecurityProduct);
            this.SetParamSimple(map, prefix + "RiskDimension", this.RiskDimension);
            this.SetParamArraySimple(map, prefix + "RelationAsset.", this.RelationAsset);
            this.SetParamArrayObj(map, prefix + "AccountRiskDetail.", this.AccountRiskDetail);
            this.SetParamArrayObj(map, prefix + "PrivilegeRiskDetail.", this.PrivilegeRiskDetail);
            this.SetParamArraySimple(map, prefix + "PolicyRiskCosFileList.", this.PolicyRiskCosFileList);
            this.SetParamArrayObj(map, prefix + "AKSKLeak.", this.AKSKLeak);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

