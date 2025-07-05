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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricDataPointMap : AbstractModel
    {
        
        /// <summary>
        /// 总调用次数监控数据点集合
        /// </summary>
        [JsonProperty("SumReqAmount")]
        public MetricDataPoint[] SumReqAmount{ get; set; }

        /// <summary>
        /// 平均错误率监控数据点集合
        /// </summary>
        [JsonProperty("AvgFailureRate")]
        public MetricDataPoint[] AvgFailureRate{ get; set; }

        /// <summary>
        /// 平均响应时间监控数据点集合
        /// </summary>
        [JsonProperty("AvgTimeCost")]
        public MetricDataPoint[] AvgTimeCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SumReqAmount.", this.SumReqAmount);
            this.SetParamArrayObj(map, prefix + "AvgFailureRate.", this.AvgFailureRate);
            this.SetParamArrayObj(map, prefix + "AvgTimeCost.", this.AvgTimeCost);
        }
    }
}

