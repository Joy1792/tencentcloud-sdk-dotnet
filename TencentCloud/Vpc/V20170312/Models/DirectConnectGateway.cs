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

    public class DirectConnectGateway : AbstractModel
    {
        
        /// <summary>
        /// 专线网关`ID`。
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// 专线网关名称。
        /// </summary>
        [JsonProperty("DirectConnectGatewayName")]
        public string DirectConnectGatewayName{ get; set; }

        /// <summary>
        /// 专线网关关联`VPC`实例`ID`。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 关联网络类型：
        /// <li>`VPC` - 私有网络</li>
        /// <li>`CCN` - 云联网</li>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 关联网络实例`ID`：
        /// <li>`NetworkType`为`VPC`时，这里为私有网络实例`ID`</li>
        /// <li>`NetworkType`为`CCN`时，这里为云联网实例`ID`</li>
        /// </summary>
        [JsonProperty("NetworkInstanceId")]
        public string NetworkInstanceId{ get; set; }

        /// <summary>
        /// 网关类型：
        /// <li>NORMAL - 标准型，注：云联网只支持标准型</li>
        /// <li>NAT - NAT型</li>
        /// NAT类型支持网络地址转换配置，类型确定后不能修改；一个私有网络可以创建一个NAT类型的专线网关和一个非NAT类型的专线网关
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 专线网关IP。
        /// </summary>
        [JsonProperty("DirectConnectGatewayIp")]
        public string DirectConnectGatewayIp{ get; set; }

        /// <summary>
        /// 专线网关关联`CCN`实例`ID`。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 云联网路由学习类型：
        /// <li>`BGP` - 自动学习。</li>
        /// <li>`STATIC` - 静态，即用户配置。</li>
        /// </summary>
        [JsonProperty("CcnRouteType")]
        public string CcnRouteType{ get; set; }

        /// <summary>
        /// 是否启用BGP。
        /// </summary>
        [JsonProperty("EnableBGP")]
        public bool? EnableBGP{ get; set; }

        /// <summary>
        /// 开启和关闭BGP的community属性。
        /// </summary>
        [JsonProperty("EnableBGPCommunity")]
        public bool? EnableBGPCommunity{ get; set; }

        /// <summary>
        /// 绑定的NAT网关ID。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// 专线网关是否支持VXLAN架构
        /// </summary>
        [JsonProperty("VXLANSupport")]
        public bool?[] VXLANSupport{ get; set; }

        /// <summary>
        /// 云联网路由发布模式：`standard`（标准模式）、`exquisite`（精细模式）。
        /// </summary>
        [JsonProperty("ModeType")]
        public string ModeType{ get; set; }

        /// <summary>
        /// 是否为localZone专线网关。
        /// </summary>
        [JsonProperty("LocalZone")]
        public bool? LocalZone{ get; set; }

        /// <summary>
        /// 专线网关所在可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 网关流控明细启用状态：
        /// 0：关闭
        /// 1：开启
        /// </summary>
        [JsonProperty("EnableFlowDetails")]
        public ulong? EnableFlowDetails{ get; set; }

        /// <summary>
        /// 开启、关闭网关流控明细时间
        /// </summary>
        [JsonProperty("FlowDetailsUpdateTime")]
        public string FlowDetailsUpdateTime{ get; set; }

        /// <summary>
        /// 是否支持开启网关流控明细
        /// 0：不支持
        /// 1：支持
        /// </summary>
        [JsonProperty("NewAfc")]
        public ulong? NewAfc{ get; set; }

        /// <summary>
        /// 专线网关接入网络类型：
        /// <li>`VXLAN` - VXLAN类型。</li>
        /// <li>`MPLS` - MPLS类型。</li>
        /// <li>`Hybrid` - Hybrid类型。</li>
        /// </summary>
        [JsonProperty("AccessNetworkType")]
        public string AccessNetworkType{ get; set; }

        /// <summary>
        /// 跨可用区容灾专线网关的可用区列表
        /// </summary>
        [JsonProperty("HaZoneList")]
        public string[] HaZoneList{ get; set; }

        /// <summary>
        /// 专线网关自定义ASN
        /// </summary>
        [JsonProperty("GatewayAsn")]
        public ulong? GatewayAsn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayName", this.DirectConnectGatewayName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "NetworkInstanceId", this.NetworkInstanceId);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayIp", this.DirectConnectGatewayIp);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CcnRouteType", this.CcnRouteType);
            this.SetParamSimple(map, prefix + "EnableBGP", this.EnableBGP);
            this.SetParamSimple(map, prefix + "EnableBGPCommunity", this.EnableBGPCommunity);
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamArraySimple(map, prefix + "VXLANSupport.", this.VXLANSupport);
            this.SetParamSimple(map, prefix + "ModeType", this.ModeType);
            this.SetParamSimple(map, prefix + "LocalZone", this.LocalZone);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "EnableFlowDetails", this.EnableFlowDetails);
            this.SetParamSimple(map, prefix + "FlowDetailsUpdateTime", this.FlowDetailsUpdateTime);
            this.SetParamSimple(map, prefix + "NewAfc", this.NewAfc);
            this.SetParamSimple(map, prefix + "AccessNetworkType", this.AccessNetworkType);
            this.SetParamArraySimple(map, prefix + "HaZoneList.", this.HaZoneList);
            this.SetParamSimple(map, prefix + "GatewayAsn", this.GatewayAsn);
        }
    }
}

