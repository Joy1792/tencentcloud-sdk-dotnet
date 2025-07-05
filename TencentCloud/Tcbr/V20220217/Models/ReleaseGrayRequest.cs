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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleaseGrayRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境Id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 灰度类型
        /// </summary>
        [JsonProperty("GrayType")]
        public string GrayType{ get; set; }

        /// <summary>
        /// 流量类型
        /// </summary>
        [JsonProperty("TrafficType")]
        public string TrafficType{ get; set; }

        /// <summary>
        /// 流量策略
        /// </summary>
        [JsonProperty("VersionFlowItems")]
        public VersionFlowInfo[] VersionFlowItems{ get; set; }

        /// <summary>
        /// 操作标识
        /// </summary>
        [JsonProperty("OperatorRemark")]
        public string OperatorRemark{ get; set; }

        /// <summary>
        /// 流量比例
        /// </summary>
        [JsonProperty("GrayFlowRatio")]
        public long? GrayFlowRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "GrayType", this.GrayType);
            this.SetParamSimple(map, prefix + "TrafficType", this.TrafficType);
            this.SetParamArrayObj(map, prefix + "VersionFlowItems.", this.VersionFlowItems);
            this.SetParamSimple(map, prefix + "OperatorRemark", this.OperatorRemark);
            this.SetParamSimple(map, prefix + "GrayFlowRatio", this.GrayFlowRatio);
        }
    }
}

