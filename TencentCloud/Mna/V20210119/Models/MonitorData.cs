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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorData : AbstractModel
    {
        
        /// <summary>
        /// 时间点：s
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 业务指标（bps/ms/%）
        /// </summary>
        [JsonProperty("BusinessMetrics")]
        public float? BusinessMetrics{ get; set; }

        /// <summary>
        /// 网卡状态信息
        /// </summary>
        [JsonProperty("SlotNetInfo")]
        public SlotNetInfo[] SlotNetInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "BusinessMetrics", this.BusinessMetrics);
            this.SetParamArrayObj(map, prefix + "SlotNetInfo.", this.SlotNetInfo);
        }
    }
}

