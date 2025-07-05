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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnimatedGraphicTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 视频转动图模板 ID
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 动图在视频中的起始时间偏移，单位为秒。
        /// <li>不填或填0，表示从视频的起始位置开始；</li>
        /// <li>当数值大于0时（假设为 n），表示从视频的第 n 秒位置开始；</li>
        /// <li>当数值小于0时（假设为 -n），表示从视频结束 n 秒前的位置开始。</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 动图在视频中的终止时间偏移，单位为秒。
        /// <li>不填或填0，表示持续到视频的末尾终止；</li>
        /// <li>当数值大于0时（假设为 n），表示持续到视频第 n 秒时终止；</li>
        /// <li>当数值小于0时（假设为 -n），表示持续到视频结束 n 秒前终止。</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

