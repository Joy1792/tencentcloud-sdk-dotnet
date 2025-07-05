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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L7RuleHealth : AbstractModel
    {
        
        /// <summary>
        /// 配置状态，0： 正常，1：配置中，2：配置失败
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// =1表示开启；=0表示关闭
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 检查目录的URL，默认为/
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 检测间隔时间，单位秒
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 健康阈值，单位次
        /// </summary>
        [JsonProperty("AliveNum")]
        public ulong? AliveNum{ get; set; }

        /// <summary>
        /// 不健康阈值，单位次
        /// </summary>
        [JsonProperty("KickNum")]
        public ulong? KickNum{ get; set; }

        /// <summary>
        /// HTTP请求方式，取值[HEAD,GET]
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 健康检查判定正常状态码，1xx =1, 2xx=2, 3xx=4, 4xx=8,5xx=16，多个状态码值加和
        /// </summary>
        [JsonProperty("StatusCode")]
        public ulong? StatusCode{ get; set; }

        /// <summary>
        /// 是否同时下发http和https规则健康检查配置
        /// </summary>
        [JsonProperty("ProtocolFlag")]
        public ulong? ProtocolFlag{ get; set; }

        /// <summary>
        /// 被动探测开关，=1表示开启；=0表示关闭
        /// </summary>
        [JsonProperty("PassiveEnable")]
        public ulong? PassiveEnable{ get; set; }

        /// <summary>
        /// 被动探测不健康屏蔽时间
        /// </summary>
        [JsonProperty("BlockInter")]
        public ulong? BlockInter{ get; set; }

        /// <summary>
        /// 被动探测不健康统计间隔
        /// </summary>
        [JsonProperty("FailedCountInter")]
        public ulong? FailedCountInter{ get; set; }

        /// <summary>
        /// 被动探测不健康阈值
        /// </summary>
        [JsonProperty("FailedThreshold")]
        public ulong? FailedThreshold{ get; set; }

        /// <summary>
        /// 被动探测判定正常状态码，1xx =1, 2xx=2, 3xx=4, 4xx=8,5xx=16，多个状态码值加和
        /// </summary>
        [JsonProperty("PassiveStatusCode")]
        public ulong? PassiveStatusCode{ get; set; }

        /// <summary>
        /// 被动探测配置状态，0： 正常，1：配置中，2：配置失败
        /// </summary>
        [JsonProperty("PassiveStatus")]
        public ulong? PassiveStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "AliveNum", this.AliveNum);
            this.SetParamSimple(map, prefix + "KickNum", this.KickNum);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "ProtocolFlag", this.ProtocolFlag);
            this.SetParamSimple(map, prefix + "PassiveEnable", this.PassiveEnable);
            this.SetParamSimple(map, prefix + "BlockInter", this.BlockInter);
            this.SetParamSimple(map, prefix + "FailedCountInter", this.FailedCountInter);
            this.SetParamSimple(map, prefix + "FailedThreshold", this.FailedThreshold);
            this.SetParamSimple(map, prefix + "PassiveStatusCode", this.PassiveStatusCode);
            this.SetParamSimple(map, prefix + "PassiveStatus", this.PassiveStatus);
        }
    }
}

