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

namespace TencentCloud.Fmu.V20191213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StyleImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 滤镜类型，取值如下： 
        /// 1.白茶；2 白皙；3.初夏；4.东京；5.告白；6.暖阳；7.蔷薇；8.清澄；9.清透；10.甜薄荷；11.默认；12.心动；13.哑灰；14.樱桃布丁；15.自然；16.清逸；17.黑白；18.水果；19.爱情；20.冬日；21.相片；22.夏日；23.香氛；24.魅惑；25.悸动；26.沙滩；27.街拍；28.甜美；29.初吻；30.午后。
        /// </summary>
        [JsonProperty("FilterType")]
        public long? FilterType{ get; set; }

        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// 暂不支持带有alpha透明通道的图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 图片的 Url ，对应图片 base64 编码后大小不可超过5M。 
        /// 图片的 Url、Image必须提供一个，如果都提供，只使用 Url。  
        /// 图片存储于腾讯云的 Url 可保障更高下载速度和稳定性，建议图片存储于腾讯云。  
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。  
        /// 支持PNG、JPG、JPEG、BMP 等图片格式，不支持 GIF 图片。
        /// 暂不支持带有alpha透明通道的图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 滤镜效果，取值[0,100]，0表示无效果，100表示满滤镜效果。默认值为80。
        /// </summary>
        [JsonProperty("FilterDegree")]
        public long? FilterDegree{ get; set; }

        /// <summary>
        /// 返回图像方式（base64 或 url ) ，二选一。url有效期为1天。默认值为base64。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "FilterDegree", this.FilterDegree);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
        }
    }
}

