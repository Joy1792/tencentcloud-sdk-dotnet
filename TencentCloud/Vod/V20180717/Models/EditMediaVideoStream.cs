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

    public class EditMediaVideoStream : AbstractModel
    {
        
        /// <summary>
        /// 视频流的编码格式，可选值：
        /// <li>libx264：H.264 编码；</li>
        /// <li>libx265：H.265 编码；</li>
        /// <li>av1：AOMedia Video 1 编码；</li>
        /// <li>H.266：H.266 编码。</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 视频流的码率，取值范围：0 和 [128, 100000]，单位：kbps。
        /// 当取值为 0 或不填时，表示由云点播自动设置码率。
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// 分辨率自适应，可选值：
        /// <li>open：开启，此时，Width 代表视频的长边，Height 表示视频的短边；</li>
        /// <li>close：关闭，此时，Width 代表视频的宽度，Height 表示视频的高度。</li>
        /// 默认值：open。
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// 视频流宽度（或长边）的最大值，取值范围：0 和 [128, 4096]，单位：px。
        /// <li>当 Width、Height 均为 0，则分辨率取基准分辨率；</li>
        /// <li>当 Width 为 0，Height 非 0，则 Width 按基准分辨率比例缩放；</li>
        /// <li>当 Width 非 0，Height 为 0，则 Height 按基准分辨率比例缩放；</li>
        /// <li>当 Width、Height 均非 0，则分辨率按用户指定。</li>
        /// 默认值：0。
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 视频流高度（或短边）的最大值，取值范围：0 和 [128, 4096]，单位：px。
        /// <li>当 Width、Height 均为 0，则分辨率取基准分辨率；</li>
        /// <li>当 Width 为 0，Height 非 0，则 Width 按基准分辨率比例缩放；</li>
        /// <li>当 Width 非 0，Height 为 0，则 Height 按基准分辨率比例缩放；</li>
        /// <li>当 Width、Height 均非 0，则分辨率按用户指定。</li>
        /// 默认值：0。
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 视频帧率，取值范围：[0, 100]，单位：Hz。
        /// 当取值为0，将自动为视频设置帧率。
        /// 默认值为 0。
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
        }
    }
}

