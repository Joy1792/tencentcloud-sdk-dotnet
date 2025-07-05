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

    public class MediaAiAnalysisFrameTagItem : AbstractModel
    {
        
        /// <summary>
        /// 按帧标签名称。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 按帧标签名称的分类列表，CategorySet.N 表示第 N+1级分类。
        /// 比如 Tag 为“塔楼”时，CategorySet 包含两个元素：CategorySet.0 为“场景”，CategorySet.1为 “建筑”，表示按帧标签为“塔楼”，且第1级分类是“场景”，第2级分类是“建筑”。
        /// </summary>
        [JsonProperty("CategorySet")]
        public string[] CategorySet{ get; set; }

        /// <summary>
        /// 按帧标签的可信度，取值范围是 0 到 100。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamArraySimple(map, prefix + "CategorySet.", this.CategorySet);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

