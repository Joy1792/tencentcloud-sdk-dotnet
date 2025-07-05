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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterCIDRSettings : AbstractModel
    {
        
        /// <summary>
        /// 用于分配集群容器和服务 IP 的 CIDR，不得与 VPC CIDR 冲突，也不得与同 VPC 内其他集群 CIDR 冲突。且网段范围必须在内网网段内，例如:10.1.0.0/14, 192.168.0.1/18,172.16.0.0/16。
        /// </summary>
        [JsonProperty("ClusterCIDR")]
        public string ClusterCIDR{ get; set; }

        /// <summary>
        /// 是否忽略 ClusterCIDR 冲突错误, 默认不忽略
        /// </summary>
        [JsonProperty("IgnoreClusterCIDRConflict")]
        public bool? IgnoreClusterCIDRConflict{ get; set; }

        /// <summary>
        /// 集群中每个Node上最大的Pod数量。取值范围16～256。不为2的幂值时会向上取最接近的2的幂值。
        /// </summary>
        [JsonProperty("MaxNodePodNum")]
        public ulong? MaxNodePodNum{ get; set; }

        /// <summary>
        /// 集群最大的service数量。取值范围32～32768，不为2的幂值时会向上取最接近的2的幂值。默认值256
        /// </summary>
        [JsonProperty("MaxClusterServiceNum")]
        public ulong? MaxClusterServiceNum{ get; set; }

        /// <summary>
        /// 用于分配集群服务 IP 的 CIDR，不得与 VPC CIDR 冲突，也不得与同 VPC 内其他集群 CIDR 冲突。且网段范围必须在内网网段内，例如:10.1.0.0/14, 192.168.0.1/18,172.16.0.0/16。
        /// </summary>
        [JsonProperty("ServiceCIDR")]
        public string ServiceCIDR{ get; set; }

        /// <summary>
        /// VPC-CNI网络模式下，弹性网卡的子网Id。
        /// </summary>
        [JsonProperty("EniSubnetIds")]
        public string[] EniSubnetIds{ get; set; }

        /// <summary>
        /// VPC-CNI网络模式下，弹性网卡IP的回收时间，取值范围[300,15768000)
        /// </summary>
        [JsonProperty("ClaimExpiredSeconds")]
        public long? ClaimExpiredSeconds{ get; set; }

        /// <summary>
        /// 是否忽略 ServiceCIDR 冲突错误, 仅在 VPC-CNI 模式生效，默认不忽略
        /// </summary>
        [JsonProperty("IgnoreServiceCIDRConflict")]
        public bool? IgnoreServiceCIDRConflict{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterCIDR", this.ClusterCIDR);
            this.SetParamSimple(map, prefix + "IgnoreClusterCIDRConflict", this.IgnoreClusterCIDRConflict);
            this.SetParamSimple(map, prefix + "MaxNodePodNum", this.MaxNodePodNum);
            this.SetParamSimple(map, prefix + "MaxClusterServiceNum", this.MaxClusterServiceNum);
            this.SetParamSimple(map, prefix + "ServiceCIDR", this.ServiceCIDR);
            this.SetParamArraySimple(map, prefix + "EniSubnetIds.", this.EniSubnetIds);
            this.SetParamSimple(map, prefix + "ClaimExpiredSeconds", this.ClaimExpiredSeconds);
            this.SetParamSimple(map, prefix + "IgnoreServiceCIDRConflict", this.IgnoreServiceCIDRConflict);
        }
    }
}

