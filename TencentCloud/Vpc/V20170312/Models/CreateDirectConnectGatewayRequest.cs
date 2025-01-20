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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDirectConnectGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// 专线网关名称
        /// </summary>
        [JsonProperty("DirectConnectGatewayName")]
        public string DirectConnectGatewayName{ get; set; }

        /// <summary>
        /// 关联网络类型，可选值：
        /// <li>VPC - 私有网络</li>
        /// <li>CCN - 云联网</li>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// <li>NetworkType 为 VPC 时，这里传值为私有网络实例ID</li>
        /// <li>NetworkType 为 CCN 时，这里传值为云联网实例ID</li>
        /// </summary>
        [JsonProperty("NetworkInstanceId")]
        public string NetworkInstanceId{ get; set; }

        /// <summary>
        /// 网关类型，可选值：
        /// <li>NORMAL - （默认）标准型，注：云联网只支持标准型</li>
        /// <li>NAT - NAT型</li>NAT类型支持网络地址转换配置，类型确定后不能修改；一个私有网络可以创建一个NAT类型的专线网关和一个非NAT类型的专线网关
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// 云联网路由发布模式，可选值：`standard`（标准模式）、`exquisite`（精细模式）。只有云联网类型专线网关才支持`ModeType`。
        /// </summary>
        [JsonProperty("ModeType")]
        public string ModeType{ get; set; }

        /// <summary>
        /// 专线网关自定义ASN，范围：45090，64512-65534 和4200000000-4294967294
        /// </summary>
        [JsonProperty("GatewayAsn")]
        public ulong? GatewayAsn{ get; set; }

        /// <summary>
        /// 专线网关可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 专线网关高可用区容灾组ID
        /// </summary>
        [JsonProperty("HaZoneGroupId")]
        public string HaZoneGroupId{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectGatewayName", this.DirectConnectGatewayName);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "NetworkInstanceId", this.NetworkInstanceId);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "ModeType", this.ModeType);
            this.SetParamSimple(map, prefix + "GatewayAsn", this.GatewayAsn);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "HaZoneGroupId", this.HaZoneGroupId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

