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

    public class ImageWatermarkInputForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 水印图片 [Base64](https://tools.ietf.org/html/rfc4648) 编码后的字符串。支持 jpeg、png 图片格式。
        /// </summary>
        [JsonProperty("ImageContent")]
        public string ImageContent{ get; set; }

        /// <summary>
        /// 水印的宽度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示水印 Width 为视频宽度的百分比大小，如 10% 表示 Width 为视频宽度的 10%；</li>
        /// <li>当字符串以 px 结尾，表示水印 Width 单位为像素，如 100px 表示 Width 为 100 像素。取值范围为[8, 4096]。</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// 水印的高度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示水印 Height 为视频高度的百分比大小，如 10% 表示 Height 为视频高度的 10%；</li>
        /// <li>当字符串以 px 结尾，表示水印 Height 单位为像素，如 100px 表示 Height 为 100 像素。取值范围为0或[8, 4096]。</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// 水印重复类型。使用场景：水印为动态图像。取值范围：
        /// <li>once：动态水印播放完后，不再出现；</li>
        /// <li>repeat_last_frame：水印播放完后，停留在最后一帧；</li>
        /// <li>repeat：水印循环播放，直到视频结束。</li>
        /// </summary>
        [JsonProperty("RepeatType")]
        public string RepeatType{ get; set; }

        /// <summary>
        /// 图片透明度，取值范围：[0, 100]
        /// <li>0：完全不透明</li>
        /// <li>100：完全透明。</li>
        /// </summary>
        [JsonProperty("Transparency")]
        public long? Transparency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageContent", this.ImageContent);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "RepeatType", this.RepeatType);
            this.SetParamSimple(map, prefix + "Transparency", this.Transparency);
        }
    }
}

