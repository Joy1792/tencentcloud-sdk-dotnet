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

    public class MediaProcessTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 视频转码任务列表。
        /// </summary>
        [JsonProperty("TranscodeTaskSet")]
        public TranscodeTaskInput[] TranscodeTaskSet{ get; set; }

        /// <summary>
        /// 视频转动图任务列表。
        /// </summary>
        [JsonProperty("AnimatedGraphicTaskSet")]
        public AnimatedGraphicTaskInput[] AnimatedGraphicTaskSet{ get; set; }

        /// <summary>
        /// 对视频按时间点截图任务列表。
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTaskSet")]
        public SnapshotByTimeOffsetTaskInput[] SnapshotByTimeOffsetTaskSet{ get; set; }

        /// <summary>
        /// 对视频采样截图任务列表。
        /// </summary>
        [JsonProperty("SampleSnapshotTaskSet")]
        public SampleSnapshotTaskInput[] SampleSnapshotTaskSet{ get; set; }

        /// <summary>
        /// 对视频截雪碧图任务列表。
        /// </summary>
        [JsonProperty("ImageSpriteTaskSet")]
        public ImageSpriteTaskInput[] ImageSpriteTaskSet{ get; set; }

        /// <summary>
        /// 对视频截图做封面任务列表。
        /// </summary>
        [JsonProperty("CoverBySnapshotTaskSet")]
        public CoverBySnapshotTaskInput[] CoverBySnapshotTaskSet{ get; set; }

        /// <summary>
        /// 对视频转自适应码流任务列表。
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingTaskSet")]
        public AdaptiveDynamicStreamingTaskInput[] AdaptiveDynamicStreamingTaskSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TranscodeTaskSet.", this.TranscodeTaskSet);
            this.SetParamArrayObj(map, prefix + "AnimatedGraphicTaskSet.", this.AnimatedGraphicTaskSet);
            this.SetParamArrayObj(map, prefix + "SnapshotByTimeOffsetTaskSet.", this.SnapshotByTimeOffsetTaskSet);
            this.SetParamArrayObj(map, prefix + "SampleSnapshotTaskSet.", this.SampleSnapshotTaskSet);
            this.SetParamArrayObj(map, prefix + "ImageSpriteTaskSet.", this.ImageSpriteTaskSet);
            this.SetParamArrayObj(map, prefix + "CoverBySnapshotTaskSet.", this.CoverBySnapshotTaskSet);
            this.SetParamArrayObj(map, prefix + "AdaptiveDynamicStreamingTaskSet.", this.AdaptiveDynamicStreamingTaskSet);
        }
    }
}

