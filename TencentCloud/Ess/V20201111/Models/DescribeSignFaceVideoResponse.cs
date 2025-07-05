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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSignFaceVideoResponse : AbstractModel
    {
        
        /// <summary>
        /// 核身视频结果。
        /// </summary>
        [JsonProperty("VideoData")]
        public DetectInfoVideoData VideoData{ get; set; }

        /// <summary>
        /// 意愿核身问答模式结果。若未使用该意愿核身功能，该字段返回值可以不处理。
        /// </summary>
        [JsonProperty("IntentionQuestionResult")]
        public IntentionQuestionResult IntentionQuestionResult{ get; set; }

        /// <summary>
        /// 意愿核身点头确认模式的结果信息，若未使用该意愿核身功能，该字段返回值可以不处理。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentionActionResult")]
        public IntentionActionResult IntentionActionResult{ get; set; }

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
            this.SetParamObj(map, prefix + "VideoData.", this.VideoData);
            this.SetParamObj(map, prefix + "IntentionQuestionResult.", this.IntentionQuestionResult);
            this.SetParamObj(map, prefix + "IntentionActionResult.", this.IntentionActionResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

