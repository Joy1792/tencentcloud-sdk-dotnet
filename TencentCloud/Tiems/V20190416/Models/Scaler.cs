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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Scaler : AbstractModel
    {
        
        /// <summary>
        /// 最大副本数，ScaleMode 为 MANUAL 时辞会此值会被置为 StartReplicas 取值
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public ulong? MaxReplicas{ get; set; }

        /// <summary>
        /// 最小副本数，ScaleMode 为 MANUAL 时辞会此值会被置为 StartReplicas 取值
        /// </summary>
        [JsonProperty("MinReplicas")]
        public ulong? MinReplicas{ get; set; }

        /// <summary>
        /// 起始副本数
        /// </summary>
        [JsonProperty("StartReplicas")]
        public ulong? StartReplicas{ get; set; }

        /// <summary>
        /// 扩缩容指标，选择自动扩缩容时至少需要选择一个指标，支持CPU-UTIL、MEMORY-UTIL
        /// </summary>
        [JsonProperty("HpaMetrics")]
        public Option[] HpaMetrics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "StartReplicas", this.StartReplicas);
            this.SetParamArrayObj(map, prefix + "HpaMetrics.", this.HpaMetrics);
        }
    }
}

