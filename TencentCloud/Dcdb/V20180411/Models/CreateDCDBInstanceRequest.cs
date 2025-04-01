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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDCDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 分片节点可用区分布，可填写多个可用区。
        /// 注意当前可售卖的可用区需要通过DescribeDCDBSaleInfo接口拉取。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 欲购买的时长，单位：月。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 分片内存大小，单位：GB，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardMemory")]
        public long? ShardMemory{ get; set; }

        /// <summary>
        /// 分片存储空间大小，单位：GB，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardStorage")]
        public long? ShardStorage{ get; set; }

        /// <summary>
        /// 单个分片节点个数，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardNodeCount")]
        public long? ShardNodeCount{ get; set; }

        /// <summary>
        /// 实例分片个数，可选范围2-8，可以通过升级实例进行新增分片到最多64个分片。
        /// </summary>
        [JsonProperty("ShardCount")]
        public long? ShardCount{ get; set; }

        /// <summary>
        /// 欲购买实例的数量
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 项目 ID，可以通过查看项目列表获取，不传则关联到默认项目
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 虚拟私有网络 ID，不传或传空表示创建为基础网络
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 虚拟私有网络子网 ID，VpcId不为空时必填
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 数据库引擎版本，当前可选：8.0，5.7，10.1，10.0。
        /// </summary>
        [JsonProperty("DbVersionId")]
        public string DbVersionId{ get; set; }

        /// <summary>
        /// 是否自动使用代金券进行支付，默认不使用。
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID列表，目前仅支持指定一张代金券。
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// 安全组id
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// 实例名称， 可以通过该字段自主的设置实例的名字
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 是否支持IPv6，0:不支持，1:支持
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public long? Ipv6Flag{ get; set; }

        /// <summary>
        /// 标签键值对数组
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// 参数列表。本接口的可选值为：character_set_server（字符集，必传），lower_case_table_names（表名大小写敏感，必传，0 - 敏感；1-不敏感），innodb_page_size（innodb数据页，默认16K），sync_mode（同步模式：0 - 异步； 1 - 强同步；2 - 强同步可退化。默认为强同步可退化）。
        /// </summary>
        [JsonProperty("InitParams")]
        public DBParamValue[] InitParams{ get; set; }

        /// <summary>
        /// DCN源地域
        /// </summary>
        [JsonProperty("DcnRegion")]
        public string DcnRegion{ get; set; }

        /// <summary>
        /// DCN源实例ID
        /// </summary>
        [JsonProperty("DcnInstanceId")]
        public string DcnInstanceId{ get; set; }

        /// <summary>
        /// 自动续费标记，0:默认状态(用户未设置，即初始状态即手动续费，用户开通了预付费不停服特权也会进行自动续费)， 1:自动续费，2:明确不自动续费(用户设置)。若业务无续费概念或无需自动续费，需要设置为0
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 安全组ids，安全组可以传数组形式，兼容之前SecurityGroupId参数
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// DCN同步模式，0：异步， 1：强同步 
        /// </summary>
        [JsonProperty("DcnSyncMode")]
        public long? DcnSyncMode{ get; set; }

        /// <summary>
        /// Cpu类型，如：英特尔：Intel/AMD，海光：Hygon，默认Intel/AMD
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ShardMemory", this.ShardMemory);
            this.SetParamSimple(map, prefix + "ShardStorage", this.ShardStorage);
            this.SetParamSimple(map, prefix + "ShardNodeCount", this.ShardNodeCount);
            this.SetParamSimple(map, prefix + "ShardCount", this.ShardCount);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DbVersionId", this.DbVersionId);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamArrayObj(map, prefix + "InitParams.", this.InitParams);
            this.SetParamSimple(map, prefix + "DcnRegion", this.DcnRegion);
            this.SetParamSimple(map, prefix + "DcnInstanceId", this.DcnInstanceId);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "DcnSyncMode", this.DcnSyncMode);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
        }
    }
}

