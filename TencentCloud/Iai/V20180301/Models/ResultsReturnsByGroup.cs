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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResultsReturnsByGroup : AbstractModel
    {
        
        /// <summary>
        /// 检测出的人脸框位置。
        /// </summary>
        [JsonProperty("FaceRect")]
        public FaceRect FaceRect{ get; set; }

        /// <summary>
        /// 识别结果。
        /// </summary>
        [JsonProperty("GroupCandidates")]
        public GroupCandidate[] GroupCandidates{ get; set; }

        /// <summary>
        /// 检测出的人脸图片状态返回码。0 表示正常。 
        /// -1601代表不符合图片质量控制要求，此时Candidate内容为空。
        /// </summary>
        [JsonProperty("RetCode")]
        public long? RetCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FaceRect.", this.FaceRect);
            this.SetParamArrayObj(map, prefix + "GroupCandidates.", this.GroupCandidates);
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
        }
    }
}

