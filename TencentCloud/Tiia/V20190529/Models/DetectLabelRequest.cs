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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectLabelRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片 Base64 编码数据。
        /// 与ImageUrl同时存在时优先使用ImageUrl字段。
        /// 图片限制：
        /// • 图片格式：PNG、JPG、JPEG、BMP。 
        /// • 图片大小：经Base64编码后不超过4M。
        /// **<font color=#1E90FF>注意：图片需要Base64编码，并且要去掉编码头部。</font>**
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片 URL 地址。 
        /// 图片限制： 
        /// • 图片格式：PNG、JPG、JPEG、BMP。 
        /// • 图片大小：所下载图片经Base64编码后不超过4M。图片下载时间不超过3秒。 
        /// 建议：
        /// • 图片像素：大于50*50像素，否则影响识别效果； 
        /// • 长宽比：长边:短边<5； 
        /// • 接口响应时间会受到图片下载时间的影响，建议使用更可靠的存储服务，推荐将图片存储在腾讯云COS。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 本次调用支持的识别场景，可选值如下：
        /// • WEB，针对网络图片优化;
        /// • CAMERA，针对手机摄像头拍摄图片优化;
        /// • ALBUM，针对手机相册、网盘产品优化;
        /// • NEWS，针对新闻、资讯、广电等行业优化；
        /// 如果不传此参数，则默认为WEB。
        /// 
        /// 支持多场景（Scenes）一起检测。例如，使用 Scenes=["WEB", "CAMERA"]，即对一张图片使用两个模型同时检测，输出两套识别结果。
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
        }
    }
}

