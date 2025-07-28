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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveActivityResult : AbstractModel
    {
        
        /// <summary>
        /// 原子任务类型。
        /// <li>LiveRecord：直播录制。</li>
        /// <li>AiQualityControl：媒体质检。</li>
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// 原子任务输出。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveActivityResItem")]
        public LiveActivityResItem LiveActivityResItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamObj(map, prefix + "LiveActivityResItem.", this.LiveActivityResItem);
        }
    }
}

