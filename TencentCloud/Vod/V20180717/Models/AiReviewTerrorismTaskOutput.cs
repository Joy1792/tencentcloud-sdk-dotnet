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

    public class AiReviewTerrorismTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// 视频暴恐评分，分值为0到100。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 暴恐结果建议，取值范围：
        /// <li>pass。</li>
        /// <li>review。</li>
        /// <li>block。</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 视频暴恐结果标签，取值范围：
        /// <li>guns：武器枪支。</li>
        /// <li>crowd：人群聚集。</li>
        /// <li>police：警察部队。</li>
        /// <li>bloody：血腥画面。</li>
        /// <li>banners：暴恐旗帜。</li>
        /// <li>militant：武装分子。</li>
        /// <li>explosion：爆炸火灾。</li>
        /// <li>terrorists：暴恐人物。</li>
        /// <li>scenario：暴恐画面。</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 有暴恐嫌疑的视频片段列表。
        /// <font color=red>注意</font> ：该列表最多仅展示前 100 个元素。如希望获得完整结果，请从 SegmentSetFileUrl 对应的文件中获取。
        /// </summary>
        [JsonProperty("SegmentSet")]
        public MediaContentReviewSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// 暴恐嫌疑的视频片段列表文件 URL。文件的内容为 JSON，数据结构与 SegmentSet 字段一致。 （文件不会永久存储，到达SegmentSetFileUrlExpireTime 时间点后文件将被删除）。
        /// </summary>
        [JsonProperty("SegmentSetFileUrl")]
        public string SegmentSetFileUrl{ get; set; }

        /// <summary>
        /// 暴恐嫌疑的视频片段列表文件 URL 失效时间，使用  [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("SegmentSetFileUrlExpireTime")]
        public string SegmentSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrl", this.SegmentSetFileUrl);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrlExpireTime", this.SegmentSetFileUrlExpireTime);
        }
    }
}

