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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextToSpeechRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要转语音的文字内容，长度范围：[1, 255]
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 文本转语音的声音配置
        /// </summary>
        [JsonProperty("Voice")]
        public Voice Voice{ get; set; }

        /// <summary>
        /// TRTC的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 文本转语音的输出音频的格式
        /// </summary>
        [JsonProperty("AudioFormat")]
        public AudioFormat AudioFormat{ get; set; }

        /// <summary>
        /// TTS的API密钥
        /// </summary>
        [JsonProperty("APIKey")]
        public string APIKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "Voice.", this.Voice);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamObj(map, prefix + "AudioFormat.", this.AudioFormat);
            this.SetParamSimple(map, prefix + "APIKey", this.APIKey);
        }
    }
}

