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

    public class MediaVideoStreamItem : AbstractModel
    {
        
        /// <summary>
        /// 视频流的码率，单位：bps。
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// 视频流的高度，单位：px。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 视频流的宽度，单位：px。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 视频流的编码格式，例如 h264。
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 帧率，单位：hz。
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 色彩空间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColorPrimaries")]
        public string ColorPrimaries{ get; set; }

        /// <summary>
        /// 色彩空间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColorSpace")]
        public string ColorSpace{ get; set; }

        /// <summary>
        /// 色彩空间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColorTransfer")]
        public string ColorTransfer{ get; set; }

        /// <summary>
        /// HDR类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HdrType")]
        public string HdrType{ get; set; }

        /// <summary>
        /// 视频Codecs。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Codecs")]
        public string Codecs{ get; set; }

        /// <summary>
        /// 帧率分子部分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FpsNumerator")]
        public long? FpsNumerator{ get; set; }

        /// <summary>
        /// 帧率分母部分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FpsDenominator")]
        public long? FpsDenominator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "ColorPrimaries", this.ColorPrimaries);
            this.SetParamSimple(map, prefix + "ColorSpace", this.ColorSpace);
            this.SetParamSimple(map, prefix + "ColorTransfer", this.ColorTransfer);
            this.SetParamSimple(map, prefix + "HdrType", this.HdrType);
            this.SetParamSimple(map, prefix + "Codecs", this.Codecs);
            this.SetParamSimple(map, prefix + "FpsNumerator", this.FpsNumerator);
            this.SetParamSimple(map, prefix + "FpsDenominator", this.FpsDenominator);
        }
    }
}

