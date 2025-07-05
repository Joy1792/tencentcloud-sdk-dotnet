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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CycleEmailParam : AbstractModel
    {
        
        /// <summary>
        /// 任务开始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 任务周期 小时维度
        /// </summary>
        [JsonProperty("IntervalTime")]
        public ulong? IntervalTime{ get; set; }

        /// <summary>
        /// 是否终止周期，用于任务更新 0否1是
        /// </summary>
        [JsonProperty("TermCycle")]
        public ulong? TermCycle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "TermCycle", this.TermCycle);
        }
    }
}

