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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageAutoAuthorizedRuleResponse : AbstractModel
    {
        
        /// <summary>
        /// 规则是否生效，0:不生效，1:已生效
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// 授权范围类别，MANUAL:自选主机节点，ALL:全部镜像
        /// </summary>
        [JsonProperty("RangeType")]
        public string RangeType{ get; set; }

        /// <summary>
        /// 授权范围是自选主机时的主机数量
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 每天最大的镜像授权数限制, 0表示无限制
        /// </summary>
        [JsonProperty("MaxDailyCount")]
        public long? MaxDailyCount{ get; set; }

        /// <summary>
        /// 规则id，用未设置时为0
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 自动扫描开关，0：关闭，1：开启
        /// </summary>
        [JsonProperty("AutoScanEnabled")]
        public long? AutoScanEnabled{ get; set; }

        /// <summary>
        /// 自动扫描范围
        /// </summary>
        [JsonProperty("ScanType")]
        public string[] ScanType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "RangeType", this.RangeType);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "MaxDailyCount", this.MaxDailyCount);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "AutoScanEnabled", this.AutoScanEnabled);
            this.SetParamArraySimple(map, prefix + "ScanType.", this.ScanType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

