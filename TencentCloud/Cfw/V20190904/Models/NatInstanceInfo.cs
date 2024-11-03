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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NatInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// nat实例id
        /// </summary>
        [JsonProperty("NatinsId")]
        public string NatinsId{ get; set; }

        /// <summary>
        /// nat实例名称
        /// </summary>
        [JsonProperty("NatinsName")]
        public string NatinsName{ get; set; }

        /// <summary>
        /// 实例所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 0: 新增模式，1:接入模式
        /// </summary>
        [JsonProperty("FwMode")]
        public long? FwMode{ get; set; }

        /// <summary>
        /// 实例带宽大小 Mbps
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// 入向带宽峰值 bps
        /// </summary>
        [JsonProperty("InFlowMax")]
        public long? InFlowMax{ get; set; }

        /// <summary>
        /// 出向带宽峰值 bps
        /// </summary>
        [JsonProperty("OutFlowMax")]
        public ulong? OutFlowMax{ get; set; }

        /// <summary>
        /// 地域中文信息
        /// </summary>
        [JsonProperty("RegionZh")]
        public string RegionZh{ get; set; }

        /// <summary>
        /// 公网ip数组
        /// </summary>
        [JsonProperty("EipAddress")]
        public string[] EipAddress{ get; set; }

        /// <summary>
        /// 内外使用ip数组
        /// </summary>
        [JsonProperty("VpcIp")]
        public string[] VpcIp{ get; set; }

        /// <summary>
        /// 实例关联子网数组
        /// </summary>
        [JsonProperty("Subnets")]
        public string[] Subnets{ get; set; }

        /// <summary>
        /// 0 :正常 1：正在初始化
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 地域区域信息
        /// </summary>
        [JsonProperty("RegionDetail")]
        public string RegionDetail{ get; set; }

        /// <summary>
        /// 实例所在可用区
        /// </summary>
        [JsonProperty("ZoneZh")]
        public string ZoneZh{ get; set; }

        /// <summary>
        /// 实例所在可用区
        /// </summary>
        [JsonProperty("ZoneZhBak")]
        public string ZoneZhBak{ get; set; }

        /// <summary>
        /// 已使用规则数
        /// </summary>
        [JsonProperty("RuleUsed")]
        public ulong? RuleUsed{ get; set; }

        /// <summary>
        /// 实例的规则限制最大规格数
        /// </summary>
        [JsonProperty("RuleMax")]
        public ulong? RuleMax{ get; set; }

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
        /// 是的需要升级引擎 支持 nat拨测 1需要 0不需要
        /// </summary>
        [JsonProperty("NeedProbeEngineUpdate")]
        public long? NeedProbeEngineUpdate{ get; set; }

        /// <summary>
        /// 引擎运行模式，Normal:正常, OnlyRoute:透明模式
        /// </summary>
        [JsonProperty("TrafficMode")]
        public string TrafficMode{ get; set; }

        /// <summary>
        /// 实例主所在可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例备所在可用区
        /// </summary>
        [JsonProperty("ZoneBak")]
        public string ZoneBak{ get; set; }

        /// <summary>
        /// 引擎预约升级时间
        /// </summary>
        [JsonProperty("ReserveTime")]
        public string ReserveTime{ get; set; }

        /// <summary>
        /// 引擎预约升级版本
        /// </summary>
        [JsonProperty("ReserveVersion")]
        public string ReserveVersion{ get; set; }

        /// <summary>
        /// 引擎预约升级版本状态 stable:稳定版；previewed:预览版
        /// </summary>
        [JsonProperty("ReserveVersionState")]
        public string ReserveVersionState{ get; set; }

        /// <summary>
        /// 弹性开关
        /// 1 打开
        /// 0 关闭
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
            this.SetParamSimple(map, prefix + "NatinsId", this.NatinsId);
            this.SetParamSimple(map, prefix + "NatinsName", this.NatinsName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "FwMode", this.FwMode);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "InFlowMax", this.InFlowMax);
            this.SetParamSimple(map, prefix + "OutFlowMax", this.OutFlowMax);
            this.SetParamSimple(map, prefix + "RegionZh", this.RegionZh);
            this.SetParamArraySimple(map, prefix + "EipAddress.", this.EipAddress);
            this.SetParamArraySimple(map, prefix + "VpcIp.", this.VpcIp);
            this.SetParamArraySimple(map, prefix + "Subnets.", this.Subnets);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RegionDetail", this.RegionDetail);
            this.SetParamSimple(map, prefix + "ZoneZh", this.ZoneZh);
            this.SetParamSimple(map, prefix + "ZoneZhBak", this.ZoneZhBak);
            this.SetParamSimple(map, prefix + "RuleUsed", this.RuleUsed);
            this.SetParamSimple(map, prefix + "RuleMax", this.RuleMax);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "UpdateEnable", this.UpdateEnable);
            this.SetParamSimple(map, prefix + "NeedProbeEngineUpdate", this.NeedProbeEngineUpdate);
            this.SetParamSimple(map, prefix + "TrafficMode", this.TrafficMode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneBak", this.ZoneBak);
            this.SetParamSimple(map, prefix + "ReserveTime", this.ReserveTime);
            this.SetParamSimple(map, prefix + "ReserveVersion", this.ReserveVersion);
            this.SetParamSimple(map, prefix + "ReserveVersionState", this.ReserveVersionState);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticBandwidth", this.ElasticBandwidth);
            this.SetParamSimple(map, prefix + "IsFirstAfterPay", this.IsFirstAfterPay);
        }
    }
}

