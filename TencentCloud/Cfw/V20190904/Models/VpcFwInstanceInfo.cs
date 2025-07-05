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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcFwInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// VPC防火墙实例名称
        /// </summary>
        [JsonProperty("FwInsName")]
        public string FwInsName{ get; set; }

        /// <summary>
        /// VPC防火墙实例ID
        /// </summary>
        [JsonProperty("FwInsId")]
        public string FwInsId{ get; set; }

        /// <summary>
        /// VPC防火墙实例模式 0: 旧VPC模式防火墙 1: CCN模式防火墙
        /// </summary>
        [JsonProperty("FwMode")]
        public long? FwMode{ get; set; }

        /// <summary>
        /// VPC防火墙接入网络实例个数
        /// </summary>
        [JsonProperty("JoinInsNum")]
        public long? JoinInsNum{ get; set; }

        /// <summary>
        /// VPC防火墙开关个数
        /// </summary>
        [JsonProperty("FwSwitchNum")]
        public long? FwSwitchNum{ get; set; }

        /// <summary>
        /// VPC防火墙状态 0:正常 ， 1：创建中 2: 变更中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// VPC防火墙创建时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// VPC 相关云联网ID列表
        /// </summary>
        [JsonProperty("CcnId")]
        public string[] CcnId{ get; set; }

        /// <summary>
        /// VPC 相关云联网名称列表
        /// </summary>
        [JsonProperty("CcnName")]
        public string[] CcnName{ get; set; }

        /// <summary>
        /// VPC 相关对等连接ID列表
        /// </summary>
        [JsonProperty("PeerConnectionId")]
        public string[] PeerConnectionId{ get; set; }

        /// <summary>
        /// VPC 相关对等连接名称列表
        /// </summary>
        [JsonProperty("PeerConnectionName")]
        public string[] PeerConnectionName{ get; set; }

        /// <summary>
        /// VPC防火墙CVM的列表
        /// </summary>
        [JsonProperty("FwCvmLst")]
        public VpcFwCvmInsInfo[] FwCvmLst{ get; set; }

        /// <summary>
        /// VPC防火墙接入网络实例类型列表
        /// </summary>
        [JsonProperty("JoinInsLst")]
        public VpcFwJoinInstanceType[] JoinInsLst{ get; set; }

        /// <summary>
        /// 防火墙网关信息
        /// </summary>
        [JsonProperty("FwGateway")]
        public FwGateway[] FwGateway{ get; set; }

        /// <summary>
        /// 防火墙(组)ID
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// 已使用规则数
        /// </summary>
        [JsonProperty("RuleUsed")]
        public long? RuleUsed{ get; set; }

        /// <summary>
        /// 最大规则数
        /// </summary>
        [JsonProperty("RuleMax")]
        public long? RuleMax{ get; set; }

        /// <summary>
        /// 防火墙实例带宽
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 用户VPC墙总带宽
        /// </summary>
        [JsonProperty("UserVpcWidth")]
        public long? UserVpcWidth{ get; set; }

        /// <summary>
        /// 接入的vpc列表
        /// </summary>
        [JsonProperty("JoinInsIdLst")]
        public string[] JoinInsIdLst{ get; set; }

        /// <summary>
        /// 内网间峰值带宽 (单位 bps )
        /// </summary>
        [JsonProperty("FlowMax")]
        public long? FlowMax{ get; set; }

        /// <summary>
        /// 实例引擎版本
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 引擎是否可升级：0，不可升级；1，可升级
        /// </summary>
        [JsonProperty("UpdateEnable")]
        public long? UpdateEnable{ get; set; }

        /// <summary>
        /// 引擎运行模式，Normal:正常, OnlyRoute:透明模式
        /// </summary>
        [JsonProperty("TrafficMode")]
        public string TrafficMode{ get; set; }

        /// <summary>
        /// 引擎预约升级时间
        /// </summary>
        [JsonProperty("ReserveTime")]
        public string ReserveTime{ get; set; }

        /// <summary>
        /// 预约引擎升级版本
        /// </summary>
        [JsonProperty("ReserveVersion")]
        public string ReserveVersion{ get; set; }

        /// <summary>
        /// 引擎预约升级版本状态
        /// </summary>
        [JsonProperty("ReserveVersionState")]
        public string ReserveVersionState{ get; set; }

        /// <summary>
        /// 弹性开关 1打开 0关闭
        /// </summary>
        [JsonProperty("ElasticSwitch")]
        public long? ElasticSwitch{ get; set; }

        /// <summary>
        /// 弹性带宽，单位Mbps
        /// </summary>
        [JsonProperty("ElasticBandwidth")]
        public long? ElasticBandwidth{ get; set; }

        /// <summary>
        /// 是否首次开通按量付费
        /// 1 是
        /// 0 不是
        /// </summary>
        [JsonProperty("IsFirstAfterPay")]
        public long? IsFirstAfterPay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwInsName", this.FwInsName);
            this.SetParamSimple(map, prefix + "FwInsId", this.FwInsId);
            this.SetParamSimple(map, prefix + "FwMode", this.FwMode);
            this.SetParamSimple(map, prefix + "JoinInsNum", this.JoinInsNum);
            this.SetParamSimple(map, prefix + "FwSwitchNum", this.FwSwitchNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamArraySimple(map, prefix + "CcnId.", this.CcnId);
            this.SetParamArraySimple(map, prefix + "CcnName.", this.CcnName);
            this.SetParamArraySimple(map, prefix + "PeerConnectionId.", this.PeerConnectionId);
            this.SetParamArraySimple(map, prefix + "PeerConnectionName.", this.PeerConnectionName);
            this.SetParamArrayObj(map, prefix + "FwCvmLst.", this.FwCvmLst);
            this.SetParamArrayObj(map, prefix + "JoinInsLst.", this.JoinInsLst);
            this.SetParamArrayObj(map, prefix + "FwGateway.", this.FwGateway);
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "RuleUsed", this.RuleUsed);
            this.SetParamSimple(map, prefix + "RuleMax", this.RuleMax);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "UserVpcWidth", this.UserVpcWidth);
            this.SetParamArraySimple(map, prefix + "JoinInsIdLst.", this.JoinInsIdLst);
            this.SetParamSimple(map, prefix + "FlowMax", this.FlowMax);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "UpdateEnable", this.UpdateEnable);
            this.SetParamSimple(map, prefix + "TrafficMode", this.TrafficMode);
            this.SetParamSimple(map, prefix + "ReserveTime", this.ReserveTime);
            this.SetParamSimple(map, prefix + "ReserveVersion", this.ReserveVersion);
            this.SetParamSimple(map, prefix + "ReserveVersionState", this.ReserveVersionState);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticBandwidth", this.ElasticBandwidth);
            this.SetParamSimple(map, prefix + "IsFirstAfterPay", this.IsFirstAfterPay);
        }
    }
}

