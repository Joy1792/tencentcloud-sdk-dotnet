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

    public class MediaSourceData : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件的来源类别：
        /// <li>Record：来自录制。如直播录制、直播时移录制等。</li>
        /// <li>Upload：来自上传。如拉取上传、服务端上传、客户端 UGC 上传等。</li>
        /// <li>VideoProcessing：来自视频处理。如视频拼接、视频剪辑等。</li>
        /// <li>TrtcRecord：来自TRTC 伴生录制。</li>
        /// <li>WebPageRecord：来自全景录制。</li>
        /// <li>Unknown：未知来源。</li>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 用户创建文件时透传的字段。
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// 直播录制信息，当文件来源为 Record 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveRecordInfo")]
        public LiveRecordInfo LiveRecordInfo{ get; set; }

        /// <summary>
        /// TRTC 伴生录制信息，当文件来源为 TrtcRecord 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrtcRecordInfo")]
        public TrtcRecordInfo TrtcRecordInfo{ get; set; }

        /// <summary>
        /// 全景录制信息，当文件来源为 WebPageRecord 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebPageRecordInfo")]
        public WebPageRecordInfo WebPageRecordInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
            this.SetParamObj(map, prefix + "LiveRecordInfo.", this.LiveRecordInfo);
            this.SetParamObj(map, prefix + "TrtcRecordInfo.", this.TrtcRecordInfo);
            this.SetParamObj(map, prefix + "WebPageRecordInfo.", this.WebPageRecordInfo);
        }
    }
}

