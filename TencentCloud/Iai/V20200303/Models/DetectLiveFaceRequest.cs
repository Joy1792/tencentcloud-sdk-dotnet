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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectLiveFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。
        /// jpg格式长边像素不可超过4000，其他格式图片长边像素不可超2000。（图片的宽高比请接近3:4，不符合宽高比的图片返回的分值不具备参考意义）。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。
        /// jpg格式长边像素不可超过4000，其他格式图片长边像素不可超2000。
        /// Url、Image必须提供一个，如果都提供，只使用 Url。 
        /// （图片的宽高比请接近 3:4，不符合宽高比的图片返回的分值不具备参考意义） 
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 人脸识别服务所用的算法模型版本。
        /// 
        /// 目前入参支持 “2.0”和“3.0“ 两个输入。
        /// 
        /// 2020年4月2日开始，默认为“3.0”，之前使用过本接口的账号若未填写本参数默认为“2.0”。
        /// 
        /// 2020年11月26日后开通服务的账号仅支持输入“3.0”。
        /// 
        /// 不同算法模型版本对应的人脸识别算法不同，新版本的整体效果会优于旧版本，建议使用“3.0”版本。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
        }
    }
}

