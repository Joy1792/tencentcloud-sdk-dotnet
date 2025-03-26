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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrivateZone : AbstractModel
    {
        
        /// <summary>
        /// 私有域id: zone-xxxxxxxx
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 域名所有者uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public long? OwnerUin{ get; set; }

        /// <summary>
        /// 私有域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// 记录数
        /// </summary>
        [JsonProperty("RecordCount")]
        public long? RecordCount{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 绑定的Vpc列表
        /// </summary>
        [JsonProperty("VpcSet")]
        public VpcInfo[] VpcSet{ get; set; }

        /// <summary>
        /// 私有域绑定VPC状态，未关联vpc：SUSPEND，已关联VPC：ENABLED
        /// ，关联VPC失败：FAILED
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 域名递归解析状态：开通：ENABLED, 关闭，DISABLED
        /// </summary>
        [JsonProperty("DnsForwardStatus")]
        public string DnsForwardStatus{ get; set; }

        /// <summary>
        /// 标签键值对集合
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 绑定的关联账号的vpc列表
        /// </summary>
        [JsonProperty("AccountVpcSet")]
        public AccountVpcInfoOutput[] AccountVpcSet{ get; set; }

        /// <summary>
        /// 是否自定义TLD
        /// </summary>
        [JsonProperty("IsCustomTld")]
        public bool? IsCustomTld{ get; set; }

        /// <summary>
        /// CNAME加速状态：开通：ENABLED, 关闭，DISABLED
        /// </summary>
        [JsonProperty("CnameSpeedupStatus")]
        public string CnameSpeedupStatus{ get; set; }

        /// <summary>
        /// 转发规则名称
        /// </summary>
        [JsonProperty("ForwardRuleName")]
        public string ForwardRuleName{ get; set; }

        /// <summary>
        /// 转发规则类型：云上到云下，DOWN；云下到云上，UP，目前只支持DOWN
        /// </summary>
        [JsonProperty("ForwardRuleType")]
        public string ForwardRuleType{ get; set; }

        /// <summary>
        /// 转发的地址
        /// </summary>
        [JsonProperty("ForwardAddress")]
        public string ForwardAddress{ get; set; }

        /// <summary>
        /// 终端节点名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndPointName")]
        public string EndPointName{ get; set; }

        /// <summary>
        /// 已删除的vpc
        /// </summary>
        [JsonProperty("DeletedVpcSet")]
        public VpcInfo[] DeletedVpcSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "VpcSet.", this.VpcSet);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DnsForwardStatus", this.DnsForwardStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "AccountVpcSet.", this.AccountVpcSet);
            this.SetParamSimple(map, prefix + "IsCustomTld", this.IsCustomTld);
            this.SetParamSimple(map, prefix + "CnameSpeedupStatus", this.CnameSpeedupStatus);
            this.SetParamSimple(map, prefix + "ForwardRuleName", this.ForwardRuleName);
            this.SetParamSimple(map, prefix + "ForwardRuleType", this.ForwardRuleType);
            this.SetParamSimple(map, prefix + "ForwardAddress", this.ForwardAddress);
            this.SetParamSimple(map, prefix + "EndPointName", this.EndPointName);
            this.SetParamArrayObj(map, prefix + "DeletedVpcSet.", this.DeletedVpcSet);
        }
    }
}

