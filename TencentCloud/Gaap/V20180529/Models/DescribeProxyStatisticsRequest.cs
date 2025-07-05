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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProxyStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 通道ID
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 起始时间(2019-03-25 12:00:00)
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间(2019-03-25 12:00:00)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 统计指标名称列表，支持: 
        /// 入带宽:InBandwidth, 
        /// 出带宽:OutBandwidth, 
        /// 并发:Concurrent, 
        /// 入包量:InPackets, 
        /// 出包量:OutPackets, 
        /// 丢包率:PacketLoss, 
        /// 延迟:Latency，
        /// HTTP请求量：HttpQPS, 
        /// HTTP请求量利用率：HttpQPSPercent,
        /// HTTPS请求量：HttpsQPS,
        /// HTTPS请求量利用率：HttpsQPSPercent
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// 监控粒度，目前支持60，300，3600，86400，单位：秒。
        /// 当时间范围不超过3天，支持最小粒度60秒；
        /// 当时间范围不超过7天，支持最小粒度300秒；
        /// 当时间范围不超过30天，支持最小粒度3600秒。
        /// </summary>
        [JsonProperty("Granularity")]
        public ulong? Granularity{ get; set; }

        /// <summary>
        /// 运营商（通道为三网通道时有效），支持CMCC，CUCC，CTCC，传空值或不传则合并三个运营商数据
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
        }
    }
}

