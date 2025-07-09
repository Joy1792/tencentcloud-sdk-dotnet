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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 每页输出实例的数量，参数默认值20，最大值为1000。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量，取Limit整数倍。计算公式：offset=limit*(页码-1)。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 指定实例 ID。例如：crs-xjhsdj****。请登录[Redis控制台](https://console.cloud.tencent.com/redis)在实例列表复制实例 ID。
        /// 
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例列表排序依据，枚举值如下所示：
        /// - projectId：依据项目ID排序。
        /// - createtime：依据实例创建时间排序。
        /// - instancename：依据实例名称排序。
        /// - type：依据实例类型排序。
        /// - curDeadline：依据实例到期时间排序。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 实例排序方式，默认为倒序排序。
        /// - 1：倒序。
        /// - 0：顺序。
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 私有网络 ID 数组。如果不配置该参数或设置数组为空则默认选择基础网络。例如47525。该参数暂时保留，可忽略。请根据 UniqVpcIds 参数格式设置私有网络ID数组。
        /// </summary>
        [JsonProperty("VpcIds")]
        public string[] VpcIds{ get; set; }

        /// <summary>
        /// 私有网络所属子网 ID 数组，例如：56854。该参数暂时保留，可忽略。请根据 UniqSubnetIds 参数格式设置私有网络子网 ID 数组。
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 设置模糊查询关键字段，仅实例名称支持模糊查询。
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// 项目 ID 组成的数组。
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 私有网络 ID 数组。如果不配置该参数或者设置数组为空则默认选择基础网络，如：vpc-sad23jfdfk。
        /// </summary>
        [JsonProperty("UniqVpcIds")]
        public string[] UniqVpcIds{ get; set; }

        /// <summary>
        /// 私有网络所属子网 ID 数组，如：subnet-fdj24n34j2。
        /// </summary>
        [JsonProperty("UniqSubnetIds")]
        public string[] UniqSubnetIds{ get; set; }

        /// <summary>
        /// 地域 ID 数组，该参数已经弃用，可通过公共参数Region查询对应地域。
        /// </summary>
        [JsonProperty("RegionIds")]
        public long?[] RegionIds{ get; set; }

        /// <summary>
        /// 实例状态。
        /// - 0：待初始化。
        /// - 1：流程中。
        /// - 2：运行中。
        /// - -2：已隔离。
        /// - -3：待删除。
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// 实例架构版本。
        /// - 1：单机版。
        /// - 2：主从版。
        /// - 3：集群版。
        /// </summary>
        [JsonProperty("TypeVersion")]
        public long? TypeVersion{ get; set; }

        /// <summary>
        /// 存储引擎信息。可设置为Redis-2.8、Redis-4.0、Redis-5.0、Redis-6.0 或者 CKV。
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// 续费模式。
        /// - 0：手动续费。
        /// - 1：自动续费。
        /// - 2：到期不再续费。
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long?[] AutoRenew{ get; set; }

        /// <summary>
        /// 计费模式。
        /// - postpaid：按量计费。
        /// - prepaid：包年包月。
        /// </summary>
        [JsonProperty("BillingMode")]
        public string BillingMode{ get; set; }

        /// <summary>
        /// 实例类型。
        /// - 2：Redis 2.8 内存版（标准架构）。
        /// - 3：CKV 3.2 内存版（标准架构）。
        /// - 4：CKV 3.2 内存版（集群架构）。
        /// - 5：Redis 2.8 内存版（单机）。
        /// - 6：Redis 4.0 内存版（标准架构）。
        /// - 7：Redis 4.0 内存版（集群架构）。
        /// - 8：Redis 5.0 内存版（标准架构）。
        /// - 9：Redis 5.0 内存版（集群架构）。
        /// - 15：Redis 6.2 内存版（标准架构）。
        /// - 16：Redis 6.2 内存版（集群架构）。
        /// - 17：Redis 7.0 内存版（标准架构）。
        /// - 18：Redis 7.0 内存版（集群架构）。
        /// - 200:Memcached 1.6 内存版（集群架构）。
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 该参数为数组类型，支持配置实例名称、实例 ID、IP地址，其中实例名称为模糊匹配，实例 ID 和 IP 地址精确匹配。
        /// 
        /// - 数组中每一个元素取并集进行匹配查询。
        /// - **InstanceId** 与 **SearchKeys** 同时配置，则取二者交集进行匹配查询。
        /// </summary>
        [JsonProperty("SearchKeys")]
        public string[] SearchKeys{ get; set; }

        /// <summary>
        /// 内部参数，用户可忽略。
        /// </summary>
        [JsonProperty("TypeList")]
        public long?[] TypeList{ get; set; }

        /// <summary>
        /// 内部参数，用户可忽略。
        /// </summary>
        [JsonProperty("MonitorVersion")]
        public string MonitorVersion{ get; set; }

        /// <summary>
        /// 根据标签的 Key 和 Value 筛选资源。该参数不配置或者数组设置为空值，则不根据标签进行过滤。
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTagInfo[] InstanceTags{ get; set; }

        /// <summary>
        /// 根据标签的 Key 筛选资源，该参数不配置或者数组设置为空值，则不根据标签Key进行过滤。
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }

        /// <summary>
        /// 实例的产品版本。如果该参数不配置或者数组设置为空值，则默认不依据此参数过滤实例。
        /// - local：本地盘版。
        /// - cdc：独享集群版。
        /// </summary>
        [JsonProperty("ProductVersions")]
        public string[] ProductVersions{ get; set; }

        /// <summary>
        /// 批量查询指定的实例 ID，返回结果已 Limit 限制为主。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 可用区模式。
        /// - singleaz：单可用区。
        /// - multiaz：多可用区。
        /// </summary>
        [JsonProperty("AzMode")]
        public string AzMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "UniqVpcIds.", this.UniqVpcIds);
            this.SetParamArraySimple(map, prefix + "UniqSubnetIds.", this.UniqSubnetIds);
            this.SetParamArraySimple(map, prefix + "RegionIds.", this.RegionIds);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "TypeVersion", this.TypeVersion);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamArraySimple(map, prefix + "AutoRenew.", this.AutoRenew);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "SearchKeys.", this.SearchKeys);
            this.SetParamArraySimple(map, prefix + "TypeList.", this.TypeList);
            this.SetParamSimple(map, prefix + "MonitorVersion", this.MonitorVersion);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamArraySimple(map, prefix + "TagKeys.", this.TagKeys);
            this.SetParamArraySimple(map, prefix + "ProductVersions.", this.ProductVersions);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "AzMode", this.AzMode);
        }
    }
}

