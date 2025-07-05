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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceMetricSource : AbstractModel
    {
        
        /// <summary>
        /// 资源名称 cpu/memory
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 目标平均利用率
        /// </summary>
        [JsonProperty("TargetAverageUtilization")]
        public long? TargetAverageUtilization{ get; set; }

        /// <summary>
        /// 目标平均值
        /// </summary>
        [JsonProperty("TargetAverageValue")]
        public string TargetAverageValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TargetAverageUtilization", this.TargetAverageUtilization);
            this.SetParamSimple(map, prefix + "TargetAverageValue", this.TargetAverageValue);
        }
    }
}

